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
				using Gmailconsole.Models;
				using Microsoft.AspNetCore.Mvc.Infrastructure;
				using Microsoft.AspNetCore.HttpOverrides;
                using Microsoft.Extensions.Configuration;
                using Microsoft.Extensions.Logging;
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 09/12/2023 11:11:20
				
                [Area("Admin")]
                
				public class MailnotifyController : Controller
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
                    private readonly ILogger<MailnotifyController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("Gmailconsoletoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public MailnotifyController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<MailnotifyController> logger)
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

	

					
			  public virtual IActionResult Add_Mail_notify()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Mail_notify(MailnotifyModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("Mailnotifyid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Mail_notify";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("GmailconsoleloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("GmailconsoleloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("Gmailconsolerole_JSON") != null){
					DataTable Gmailconsolerole_JSON =HttpContext.Session.GetSession<DataTable>("Gmailconsoleroles");
						 DataView dv = new DataView(Gmailconsolerole_JSON);
						 dv.RowFilter = "controllername='Mailnotify' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 MailnotifyModelValidator validator = new MailnotifyModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/Mailnotify/Add_Mail_notify", model);
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
                _logger.LogError("Error occured in - Mailnotify / Add_Mail_notify , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_Mail_notify(string Mailnotifyid)
			  {
					var jsonObjMailnotify = await ApiClient.Get_ApiValues(getHttpClient(), "api/Mailnotify/getById_Mailnotify?Mailnotifyid="+Mailnotifyid+"&loginUserID="+HttpContext.Session.GetString("GmailconsoleloginUserID"));
					if(jsonObjMailnotify.Length > 2)
					{
						jsonObjMailnotify = jsonObjMailnotify.Substring(1, jsonObjMailnotify.Length - 2);
						var model = JsonConvert.DeserializeObject<MailnotifyModel>(jsonObjMailnotify);
						HttpContext.Session.SetSession("GmailconsoleMailnotifyModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("Gmailconsolerole_JSON") != null){
					DataTable Gmailconsolerole_JSON =HttpContext.Session.GetSession<DataTable>("Gmailconsoleroles");
						 DataView dv = new DataView(Gmailconsolerole_JSON);
						 dv.RowFilter = "controllername='Mailnotify' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Mail_notify(MailnotifyModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("Gmailconsolerole_JSON") != null){
					DataTable Gmailconsolerole_JSON =HttpContext.Session.GetSession<DataTable>("Gmailconsoleroles");
						 DataView dv = new DataView(Gmailconsolerole_JSON);
						 dv.RowFilter = "controllername='Mailnotify' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("Mailnotifyid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Mail_notify";

							
							
							if(HttpContext.Session.GetString("GmailconsoleloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("GmailconsoleloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									MailnotifyModelValidator validator = new MailnotifyModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<MailnotifyModel> ("GmailconsoleMailnotifyModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/Mailnotify/Update_Mail_notify", model);
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
                        _logger.LogError("Error occured in - Mailnotify / Update_Mail_notify , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_Mail_notify(string Mailnotifyid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/Mailnotify/Remove_Mail_notify?Mailnotifyid="+Mailnotifyid+"&loginUserID="+HttpContext.Session.GetString("GmailconsoleloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - Mailnotify / Remove_Mail_notify , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("Gmailconsolerole_JSON") != null){
					DataTable Gmailconsolerole_JSON =HttpContext.Session.GetSession<DataTable>("Gmailconsoleroles");
						 DataView dv = new DataView(Gmailconsolerole_JSON);
						 dv.RowFilter = "controllername='Mailnotify' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Mail_notify_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Mail_notify_List(string tenantid
)
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Mailnotify/Mail_notify_List?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("GmailconsoleloginUserID")
);
			}
			 

				
			  public virtual async Task<string> getById_sp_all_Mailnotify(string Mailnotifyid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/Mailnotify/getById_sp_all_Mailnotify?Mailnotifyid="+Mailnotifyid);
					 
			  }





                    


				}


			}
