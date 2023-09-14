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
				using AIData.Models;
				using Microsoft.AspNetCore.Mvc.Infrastructure;
				using Microsoft.AspNetCore.HttpOverrides;
                using Microsoft.Extensions.Configuration;
                using Microsoft.Extensions.Logging;
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:54:53
				
                
                
				public class ProcessesController : Controller
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
                    private readonly ILogger<ProcessesController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("AIDatatoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public ProcessesController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<ProcessesController> logger)
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

	

					
			  public virtual IActionResult Add_Processes()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Processes(ProcessesModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("Processesid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Processes";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("AIDataloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("AIDataloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Processes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 ProcessesModelValidator validator = new ProcessesModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/Processes/Add_Processes", model);
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
                _logger.LogError("Error occured in - Processes / Add_Processes , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_Processes(string Processesid)
			  {
					var jsonObjProcesses = await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/getById_Processes?Processesid="+Processesid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
					if(jsonObjProcesses.Length > 2)
					{
						jsonObjProcesses = jsonObjProcesses.Substring(1, jsonObjProcesses.Length - 2);
						var model = JsonConvert.DeserializeObject<ProcessesModel>(jsonObjProcesses);
						HttpContext.Session.SetSession("AIDataProcessesModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Processes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Processes(ProcessesModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Processes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("Processesid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Processes";

							
							
							if(HttpContext.Session.GetString("AIDataloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("AIDataloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									ProcessesModelValidator validator = new ProcessesModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<ProcessesModel> ("AIDataProcessesModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/Processes/Update_Processes", model);
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
                        _logger.LogError("Error occured in - Processes / Update_Processes , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_Processes(string Processesid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/Remove_Processes?Processesid="+Processesid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - Processes / Remove_Processes , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Processes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Processes_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Processes_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/Processes_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
);
			}
			 [HttpGet()]
											public virtual async Task<string> get_Industries_List()
											{
											
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/Industries/Industries_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
);
											}
											 
											 
											[HttpGet()]
											public virtual async Task<string> get_all_Industries(string tenantid)
											{
											 
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/Industries/get_all_Industries?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
											}
											[HttpGet()]
											public virtual async Task<string> get_IndustyTypes_List()
											{
											
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/IndustyTypes_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
);
											}
											 
											 
											[HttpGet()]
											public virtual async Task<string> get_all_IndustyTypes(string tenantid)
											{
											 
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/get_all_IndustyTypes?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
											}
											[HttpGet()]
											public virtual async Task<string> get_SubTypes_List()
											{
											
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/SubTypes/SubTypes_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
);
											}
											 
											 
											[HttpGet()]
											public virtual async Task<string> get_all_SubTypes(string tenantid)
											{
											 
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/SubTypes/get_all_SubTypes?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
											}
											[HttpGet()]
											public virtual async Task<string> get_Funcitons_List()
											{
											
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/Funcitons_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
);
											}
											 
											 
											[HttpGet()]
											public virtual async Task<string> get_all_Funcitons(string tenantid)
											{
											 
											return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/get_all_Funcitons?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
											}
											

				
			  public virtual async Task<string> getById_sp_all_Processes(string Processesid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/getById_sp_all_Processes?Processesid="+Processesid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_Processes_industryname()
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/lookup_Processes_industryname?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}
[HttpGet()]
			public virtual async Task<string> lookup_Processes_industrytypename(String industryname)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/lookup_Processes_industrytypename?industryname="+industryname+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}
[HttpGet()]
			public virtual async Task<string> lookup_Processes_subtypename(String industryname,String industrytypename)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/lookup_Processes_subtypename?industryname="+industryname+"&industrytypename="+industrytypename+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}
[HttpGet()]
			public virtual async Task<string> lookup_Processes_businessfunctionname(String industryname,String industrytypename,String subtypename)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Processes/lookup_Processes_businessfunctionname?industryname="+industryname+"&industrytypename="+industrytypename+"&subtypename="+subtypename+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}





                    


				}


			}
