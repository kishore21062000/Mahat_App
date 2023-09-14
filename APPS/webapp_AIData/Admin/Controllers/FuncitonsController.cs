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
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:47:17
				
                
                
				public class FuncitonsController : Controller
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
                    private readonly ILogger<FuncitonsController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("AIDatatoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public FuncitonsController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<FuncitonsController> logger)
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

	

					
			  public virtual IActionResult Add_Funcitons()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Funcitons(FuncitonsModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("Funcitonsid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Funcitons";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("AIDataloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("AIDataloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Funcitons' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 FuncitonsModelValidator validator = new FuncitonsModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/Funcitons/Add_Funcitons", model);
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
                _logger.LogError("Error occured in - Funcitons / Add_Funcitons , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_Funcitons(string Funcitonsid)
			  {
					var jsonObjFuncitons = await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/getById_Funcitons?Funcitonsid="+Funcitonsid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
					if(jsonObjFuncitons.Length > 2)
					{
						jsonObjFuncitons = jsonObjFuncitons.Substring(1, jsonObjFuncitons.Length - 2);
						var model = JsonConvert.DeserializeObject<FuncitonsModel>(jsonObjFuncitons);
						HttpContext.Session.SetSession("AIDataFuncitonsModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Funcitons' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Funcitons(FuncitonsModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Funcitons' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("Funcitonsid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Funcitons";

							
							
							if(HttpContext.Session.GetString("AIDataloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("AIDataloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									FuncitonsModelValidator validator = new FuncitonsModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<FuncitonsModel> ("AIDataFuncitonsModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/Funcitons/Update_Funcitons", model);
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
                        _logger.LogError("Error occured in - Funcitons / Update_Funcitons , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_Funcitons(string Funcitonsid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/Remove_Funcitons?Funcitonsid="+Funcitonsid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - Funcitons / Remove_Funcitons , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='Funcitons' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Funcitons_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Funcitons_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/Funcitons_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
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
											

				
			  public virtual async Task<string> getById_sp_all_Funcitons(string Funcitonsid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/getById_sp_all_Funcitons?Funcitonsid="+Funcitonsid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_Funcitons_industryname()
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/lookup_Funcitons_industryname?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}
[HttpGet()]
			public virtual async Task<string> lookup_Funcitons_industrytypename(String industryname)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/lookup_Funcitons_industrytypename?industryname="+industryname+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}
[HttpGet()]
			public virtual async Task<string> lookup_Funcitons_subtypename(String industryname,String industrytypename)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/Funcitons/lookup_Funcitons_subtypename?industryname="+industryname+"&industrytypename="+industrytypename+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}





                    


				}


			}
