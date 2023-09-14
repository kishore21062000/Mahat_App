namespace Admin.Controllers
			{
				using System;
				using System.Data;
				using System.Linq;
				using Microsoft.AspNetCore.Mvc;
				using Newtonsoft.Json;
				using System.Net.Http;
				using System.Net.Http.Formatting;
				using System.Threading.Tasks;
				using System.Net.Http.Headers;
				using Microsoft.Extensions.Options;
				using Microsoft.AspNetCore.Http;
				using System.Collections.Generic;
				using System.IO;
				using Microsoft.AspNetCore.Hosting;
				using System.Net;
				using FluentValidation.Results;
				using DineandDiscover.Models;
				using Microsoft.AspNetCore.Mvc.Infrastructure;
				using Microsoft.AspNetCore.HttpOverrides;
                using Microsoft.Extensions.Configuration;
                using Microsoft.Extensions.Logging;
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:36:11
				
                [Area("Admin")]
                
				public class MenuandPricingController : Controller
				{	 
					private HttpClient  client = new HttpClient();
					private IWebHostEnvironment hostingEnv;
					private IOptions<ApiSettings> _balSettings;
                    private IOptions<MailSettings> _mailSettings;
					private string  url = "";
					private string  baseUrl = "";
                    private string  adminUrl = "";
                    private string  clientUrl = "";
                    private string  accesskey = "";
					private IHttpContextAccessor _accessor;
                    public IConfiguration Configuration { get; }
                    private readonly ILogger<MenuandPricingController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("DineandDiscovertoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public MenuandPricingController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<MenuandPricingController> logger)
					{
                        _logger = logger;
						this.hostingEnv = env;
						_balSettings = ApiSettings;
                        _mailSettings = MailSettings;
						url = _balSettings.Value.apiURL;
						baseUrl = _balSettings.Value.baseURL;
                        adminUrl = _balSettings.Value.adminURL;
                        clientUrl = _balSettings.Value.clientURL;
                        accesskey = _balSettings.Value.accesskey;
 
						_accessor = accessor;
                        Configuration = configuration;
                        
					}
					 public virtual IActionResult detail()
			         {
					        return View();
			         }

	

					
			  public virtual IActionResult Add_Menu_and_Pricing()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Menu_and_Pricing(MenuandPricingModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("MenuandPricingid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Menu_and_Pricing";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
						else
						return RedirectToAction(redirectTo);
					ModelState.Remove("foodi");
ModelState.Remove("foodi1");
ModelState.Remove("foodi2");
ModelState.Remove("foodi3");
ModelState.Remove("foodi4");

					

					if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='MenuandPricing' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 MenuandPricingModelValidator validator = new MenuandPricingModelValidator();
							 ValidationResult results = validator.Validate(model);
							 if (!results.IsValid)
							 {
								 var errorCollection = string.Join(" | ", results.Errors.Select(e => e.ErrorMessage.Replace("{propertyName}",e.PropertyName)));
								 strReturnMessage = errorCollection.ToString();
								 foreach (var failure in results.Errors)
								 {
									ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
								 }
							 }
							 else
							 {
								 
								 var files = Request.Form.Files;
foreach (var file in files) 
{
var filename = ContentDispositionHeaderValue
.Parse(file.ContentDisposition)
.FileName
.Trim('"'); 
string fileExtention = "." + filename.Split('.').Last(); 
Random rnd = new Random();
string uploadFileName = System.Text.RegularExpressions.Regex.Replace(filename.Split('.').First(), @"[^0-9a-zA-Z_.]+", "").Replace(" ", String.Empty)+"_"+"MenuandPricing_" +rnd.Next(1, 10000).ToString() + DateTime.Now.ToString("ddMMyyHHmmss")+ fileExtention;
if (fileExtention != ".")
{
var filanameFolder = hostingEnv.WebRootPath +  "/uploads/"; 
if (!Directory.Exists(filanameFolder))
{
Directory.CreateDirectory(filanameFolder);
}
filename  = filanameFolder + uploadFileName;
using (FileStream fs = System.IO.File.Create(filename))
{
file.CopyTo(fs);
fs.Flush();
}
if (file.Name == "foodi")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi += "|" + uploadFileName +"|";
}
if (file.Name == "foodi1")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi1 += "|" + uploadFileName +"|";
}
if (file.Name == "foodi2")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi2 += "|" + uploadFileName +"|";
}
if (file.Name == "foodi3")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi3 += "|" + uploadFileName +"|";
}
if (file.Name == "foodi4")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi4 += "|" + uploadFileName +"|";
}
}
}

								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/MenuandPricing/Add_Menu_and_Pricing", model);
							 }
					 }
					 else
					 {
							 var errorCollection = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
							 strReturnMessage = errorCollection.ToString();
					 }
			 }
			 catch (Exception ex)
			 {
                _logger.LogError("Error occured in - MenuandPricing / Add_Menu_and_Pricing , Error Message : " + ex.Message);
                Console.WriteLine(ex);
				 strReturnMessage = ex.Message;
			 }
		     ViewData["message"] = strReturnMessage;
			 if(strReturnMessage.Replace("\"", "").Contains("201.1")){
				 TempData["message"] = "Success";
				 
				 return RedirectToAction(redirectTo);
			 }else{
				  if(strReturnMessage=="401.1")
				  	 	 ViewData["message"] = "Authorization Failed";

				  return View(model);
			 }
 
		   }

				
			  public virtual async Task<IActionResult> Update_Menu_and_Pricing(string MenuandPricingid)
			  {
					var jsonObjMenuandPricing = await ApiClient.Get_ApiValues(getHttpClient(), "api/MenuandPricing/getById_MenuandPricing?MenuandPricingid="+MenuandPricingid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					if(jsonObjMenuandPricing.Length > 2)
					{
						jsonObjMenuandPricing = jsonObjMenuandPricing.Substring(1, jsonObjMenuandPricing.Length - 2);
						var model = JsonConvert.DeserializeObject<MenuandPricingModel>(jsonObjMenuandPricing);
						HttpContext.Session.SetSession("DineandDiscoverMenuandPricingModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='MenuandPricing' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Menu_and_Pricing(MenuandPricingModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='MenuandPricing' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("MenuandPricingid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Menu_and_Pricing";

							
							
							if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									MenuandPricingModelValidator validator = new MenuandPricingModelValidator();
									ValidationResult results = validator.Validate(model);
									if (!results.IsValid)
									{
										var errorCollection = string.Join(" | ", results.Errors.Select(e => e.ErrorMessage.Replace("{propertyName}",e.PropertyName)));
										strReturnMessage = errorCollection.ToString();
										foreach (var failure in results.Errors)
										{
											ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
										}
									}
									else
									{
										var files = Request.Form.Files;
foreach (var file in files) 
{
var filename = ContentDispositionHeaderValue
.Parse(file.ContentDisposition)
.FileName
.Trim('"'); 
string fileExtention = "." + filename.Split('.').Last(); 
Random rnd = new Random();
string uploadFileName = System.Text.RegularExpressions.Regex.Replace(filename.Split('.').First(), @"[^0-9a-zA-Z_.]+", "").Replace(" ", String.Empty)+"_"+"MenuandPricing_" +rnd.Next(1, 10000).ToString() + DateTime.Now.ToString("ddMMyyHHmmss")+ fileExtention;
if (fileExtention != ".")
{
var filanameFolder = hostingEnv.WebRootPath +  "/uploads/"; 
if (!Directory.Exists(filanameFolder))
{
Directory.CreateDirectory(filanameFolder);
}
filename  = filanameFolder + uploadFileName;
using (FileStream fs = System.IO.File.Create(filename))
{
file.CopyTo(fs);
fs.Flush();
}
if (file.Name == "foodi")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi += "|" + uploadFileName +"|";
}
if (file.Name == "foodi1")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi1 += "|" + uploadFileName +"|";
}
if (file.Name == "foodi2")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi2 += "|" + uploadFileName +"|";
}
if (file.Name == "foodi3")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi3 += "|" + uploadFileName +"|";
}
if (file.Name == "foodi4")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.foodi4 += "|" + uploadFileName +"|";
}
}
}

                                        var modelCopy = HttpContext.Session.GetSession<MenuandPricingModel> ("DineandDiscoverMenuandPricingModel");
if(model.foodi ==  null || model.foodi=="")
model.foodi = modelCopy.foodi;
if(model.foodi1 ==  null || model.foodi1=="")
model.foodi1 = modelCopy.foodi1;
if(model.foodi2 ==  null || model.foodi2=="")
model.foodi2 = modelCopy.foodi2;
if(model.foodi3 ==  null || model.foodi3=="")
model.foodi3 = modelCopy.foodi3;
if(model.foodi4 ==  null || model.foodi4=="")
model.foodi4 = modelCopy.foodi4;

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/MenuandPricing/Update_Menu_and_Pricing", model);
									}
							}
							else
							{
									var errorCollection = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
									strReturnMessage = errorCollection.ToString();
							}
					}
					catch (Exception ex)
					{
                        _logger.LogError("Error occured in - MenuandPricing / Update_Menu_and_Pricing , Error Message : " + ex.Message);
Console.WriteLine(ex);
						strReturnMessage = ex.Message;
					}
					ViewData["message"] = strReturnMessage;
					    if(strReturnMessage.Replace("\"", "")=="201.1"){
							TempData["message"] = "Success";
							
							return RedirectToAction(redirectTo);
						}else{
							if(strReturnMessage=="401.1")
									ViewData["message"] = "Authorization Failed";

							return View(model);
						}
		
				}
public virtual async Task<IActionResult> Remove_Menu_and_Pricing(string MenuandPricingid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/MenuandPricing/Remove_Menu_and_Pricing?MenuandPricingid="+MenuandPricingid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - MenuandPricing / Remove_Menu_and_Pricing , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='MenuandPricing' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Menu_and_Pricing_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Menu_and_Pricing_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/MenuandPricing/Menu_and_Pricing_List?loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID")
);
			}
			 [HttpGet()]
											public virtual async Task<string> get_Basic_Information_List()
											{
											
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/BasicInformation/Basic_Information_List?loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID")
);
											}
											 
											 
											[HttpGet()]
											public virtual async Task<string> get_all_BasicInformation(string tenantid)
											{
											 
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/BasicInformation/get_all_BasicInformation?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
											}
											

				
			  public virtual async Task<string> getById_sp_all_MenuandPricing(string MenuandPricingid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/MenuandPricing/getById_sp_all_MenuandPricing?MenuandPricingid="+MenuandPricingid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_MenuandPricing_menus(String tenantid)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/MenuandPricing/lookup_MenuandPricing_menus?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
			}





                    


				}


			}
