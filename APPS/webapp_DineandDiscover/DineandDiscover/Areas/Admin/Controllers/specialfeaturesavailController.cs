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
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/17/2023 08:36:16
				
                [Area("Admin")]
                
				public class specialfeaturesavailController : Controller
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
                    private readonly ILogger<specialfeaturesavailController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("DineandDiscovertoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public specialfeaturesavailController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<specialfeaturesavailController> logger)
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

	

					
			  public virtual IActionResult Add_specialfeatures_avail()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_specialfeatures_avail(specialfeaturesavailModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("specialfeaturesavailid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_specialfeatures_avail";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
						else
						return RedirectToAction(redirectTo);
					ModelState.Remove("videoofbalcony");
ModelState.Remove("imageofbalcony");
ModelState.Remove("imageofkidsplayarea");
ModelState.Remove("videoofkidsplayarea");
ModelState.Remove("imageofcocktail");
ModelState.Remove("videoofcocktail");
ModelState.Remove("imageofentrance");
ModelState.Remove("videoofoverallrestaurant");

					

					if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='specialfeaturesavail' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 specialfeaturesavailModelValidator validator = new specialfeaturesavailModelValidator();
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
string uploadFileName = System.Text.RegularExpressions.Regex.Replace(filename.Split('.').First(), @"[^0-9a-zA-Z_.]+", "").Replace(" ", String.Empty)+"_"+"specialfeaturesavail_" +rnd.Next(1, 10000).ToString() + DateTime.Now.ToString("ddMMyyHHmmss")+ fileExtention;
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
if (file.Name == "videoofbalcony")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofbalcony += "|" + uploadFileName +"|";
}
if (file.Name == "imageofbalcony")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofbalcony += "|" + uploadFileName +"|";
}
if (file.Name == "imageofkidsplayarea")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofkidsplayarea += "|" + uploadFileName +"|";
}
if (file.Name == "videoofkidsplayarea")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofkidsplayarea += "|" + uploadFileName +"|";
}
if (file.Name == "imageofcocktail")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofcocktail += "|" + uploadFileName +"|";
}
if (file.Name == "videoofcocktail")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofcocktail += "|" + uploadFileName +"|";
}
if (file.Name == "imageofentrance")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofentrance += "|" + uploadFileName +"|";
}
if (file.Name == "videoofoverallrestaurant")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofoverallrestaurant += "|" + uploadFileName +"|";
}
}
}

								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/specialfeaturesavail/Add_specialfeatures_avail", model);
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
                _logger.LogError("Error occured in - specialfeaturesavail / Add_specialfeatures_avail , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_specialfeatures_avail(string specialfeaturesavailid)
			  {
					var jsonObjspecialfeaturesavail = await ApiClient.Get_ApiValues(getHttpClient(), "api/specialfeaturesavail/getById_specialfeaturesavail?specialfeaturesavailid="+specialfeaturesavailid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					if(jsonObjspecialfeaturesavail.Length > 2)
					{
						jsonObjspecialfeaturesavail = jsonObjspecialfeaturesavail.Substring(1, jsonObjspecialfeaturesavail.Length - 2);
						var model = JsonConvert.DeserializeObject<specialfeaturesavailModel>(jsonObjspecialfeaturesavail);
						HttpContext.Session.SetSession("DineandDiscoverspecialfeaturesavailModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='specialfeaturesavail' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_specialfeatures_avail(specialfeaturesavailModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='specialfeaturesavail' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("specialfeaturesavailid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_specialfeatures_avail";

							
							
							if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									specialfeaturesavailModelValidator validator = new specialfeaturesavailModelValidator();
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
string uploadFileName = System.Text.RegularExpressions.Regex.Replace(filename.Split('.').First(), @"[^0-9a-zA-Z_.]+", "").Replace(" ", String.Empty)+"_"+"specialfeaturesavail_" +rnd.Next(1, 10000).ToString() + DateTime.Now.ToString("ddMMyyHHmmss")+ fileExtention;
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
if (file.Name == "videoofbalcony")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofbalcony += "|" + uploadFileName +"|";
}
if (file.Name == "imageofbalcony")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofbalcony += "|" + uploadFileName +"|";
}
if (file.Name == "imageofkidsplayarea")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofkidsplayarea += "|" + uploadFileName +"|";
}
if (file.Name == "videoofkidsplayarea")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofkidsplayarea += "|" + uploadFileName +"|";
}
if (file.Name == "imageofcocktail")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofcocktail += "|" + uploadFileName +"|";
}
if (file.Name == "videoofcocktail")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofcocktail += "|" + uploadFileName +"|";
}
if (file.Name == "imageofentrance")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.imageofentrance += "|" + uploadFileName +"|";
}
if (file.Name == "videoofoverallrestaurant")
{
uploadFileName = baseUrl + "/uploads/" + uploadFileName;
model.videoofoverallrestaurant += "|" + uploadFileName +"|";
}
}
}

                                        var modelCopy = HttpContext.Session.GetSession<specialfeaturesavailModel> ("DineandDiscoverspecialfeaturesavailModel");
if(model.videoofbalcony ==  null || model.videoofbalcony=="")
model.videoofbalcony = modelCopy.videoofbalcony;
if(model.imageofbalcony ==  null || model.imageofbalcony=="")
model.imageofbalcony = modelCopy.imageofbalcony;
if(model.imageofkidsplayarea ==  null || model.imageofkidsplayarea=="")
model.imageofkidsplayarea = modelCopy.imageofkidsplayarea;
if(model.videoofkidsplayarea ==  null || model.videoofkidsplayarea=="")
model.videoofkidsplayarea = modelCopy.videoofkidsplayarea;
if(model.imageofcocktail ==  null || model.imageofcocktail=="")
model.imageofcocktail = modelCopy.imageofcocktail;
if(model.videoofcocktail ==  null || model.videoofcocktail=="")
model.videoofcocktail = modelCopy.videoofcocktail;
if(model.imageofentrance ==  null || model.imageofentrance=="")
model.imageofentrance = modelCopy.imageofentrance;
if(model.videoofoverallrestaurant ==  null || model.videoofoverallrestaurant=="")
model.videoofoverallrestaurant = modelCopy.videoofoverallrestaurant;

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/specialfeaturesavail/Update_specialfeatures_avail", model);
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
                        _logger.LogError("Error occured in - specialfeaturesavail / Update_specialfeatures_avail , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_specialfeatures_avail(string specialfeaturesavailid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/specialfeaturesavail/Remove_specialfeatures_avail?specialfeaturesavailid="+specialfeaturesavailid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - specialfeaturesavail / Remove_specialfeatures_avail , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='specialfeaturesavail' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult specialfeatures_avail_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_specialfeatures_avail_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/specialfeaturesavail/specialfeatures_avail_List?loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID")
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
											

				
			  public virtual async Task<string> getById_sp_all_specialfeaturesavail(string specialfeaturesavailid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/specialfeaturesavail/getById_sp_all_specialfeaturesavail?specialfeaturesavailid="+specialfeaturesavailid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_specialfeaturesavail_specialfeaturesavail(String tenantid)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/specialfeaturesavail/lookup_specialfeaturesavail_specialfeaturesavail?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
			}





                    


				}


			}
