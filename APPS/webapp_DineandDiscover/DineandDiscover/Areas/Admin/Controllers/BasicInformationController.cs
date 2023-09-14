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
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 14:17:43
				
                [Area("Admin")]
                
				public class BasicInformationController : Controller
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
                    private readonly ILogger<BasicInformationController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("DineandDiscovertoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public BasicInformationController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<BasicInformationController> logger)
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

	

					
			  public virtual IActionResult Add_Basic_Information()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Basic_Information(BasicInformationModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("BasicInformationid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Basic_Information";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
						else
						return RedirectToAction(redirectTo);
					ModelState.Remove("restaurantimage");

					

					if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='BasicInformation' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 BasicInformationModelValidator validator = new BasicInformationModelValidator();
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
string uploadFileName = System.Text.RegularExpressions.Regex.Replace(filename.Split('.').First(), @"[^0-9a-zA-Z_.]+", "").Replace(" ", String.Empty)+"_"+"BasicInformation_" +rnd.Next(1, 10000).ToString() + DateTime.Now.ToString("ddMMyyHHmmss")+ fileExtention;
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
if (file.Name == "restaurantimage")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.restaurantimage += "|" + uploadFileName +"|";
}
}
}

								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/BasicInformation/Add_Basic_Information", model);
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
                _logger.LogError("Error occured in - BasicInformation / Add_Basic_Information , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_Basic_Information(string BasicInformationid)
			  {
					var jsonObjBasicInformation = await ApiClient.Get_ApiValues(getHttpClient(), "api/BasicInformation/getById_BasicInformation?BasicInformationid="+BasicInformationid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					if(jsonObjBasicInformation.Length > 2)
					{
						jsonObjBasicInformation = jsonObjBasicInformation.Substring(1, jsonObjBasicInformation.Length - 2);
						var model = JsonConvert.DeserializeObject<BasicInformationModel>(jsonObjBasicInformation);
						HttpContext.Session.SetSession("DineandDiscoverBasicInformationModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='BasicInformation' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Basic_Information(BasicInformationModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='BasicInformation' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("BasicInformationid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Basic_Information";

							
							
							if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									BasicInformationModelValidator validator = new BasicInformationModelValidator();
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
string uploadFileName = System.Text.RegularExpressions.Regex.Replace(filename.Split('.').First(), @"[^0-9a-zA-Z_.]+", "").Replace(" ", String.Empty)+"_"+"BasicInformation_" +rnd.Next(1, 10000).ToString() + DateTime.Now.ToString("ddMMyyHHmmss")+ fileExtention;
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
if (file.Name == "restaurantimage")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.restaurantimage += "|" + uploadFileName +"|";
}
}
}

                                        var modelCopy = HttpContext.Session.GetSession<BasicInformationModel> ("DineandDiscoverBasicInformationModel");
if(model.restaurantimage ==  null || model.restaurantimage=="")
model.restaurantimage = modelCopy.restaurantimage;

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/BasicInformation/Update_Basic_Information", model);
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
                        _logger.LogError("Error occured in - BasicInformation / Update_Basic_Information , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_Basic_Information(string BasicInformationid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/BasicInformation/Remove_Basic_Information?BasicInformationid="+BasicInformationid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - BasicInformation / Remove_Basic_Information , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='BasicInformation' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Basic_Information_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Basic_Information_List(string tenantid
)
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/BasicInformation/Basic_Information_List?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID")
);
			}
			 

				
			  public virtual async Task<string> getById_sp_all_BasicInformation(string BasicInformationid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/BasicInformation/getById_sp_all_BasicInformation?BasicInformationid="+BasicInformationid);
					 
			  }





                    


				}


			}
