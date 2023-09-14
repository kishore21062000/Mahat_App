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
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:42:42
				
                
                
				public class IndustyTypesController : Controller
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
                    private readonly ILogger<IndustyTypesController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("AIDatatoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public IndustyTypesController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<IndustyTypesController> logger)
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

	

					
			  public virtual IActionResult Add_IndustyTypes()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_IndustyTypes(IndustyTypesModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("IndustyTypesid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_IndustyTypes";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("AIDataloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("AIDataloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='IndustyTypes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 IndustyTypesModelValidator validator = new IndustyTypesModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/IndustyTypes/Add_IndustyTypes", model);
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
                _logger.LogError("Error occured in - IndustyTypes / Add_IndustyTypes , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_IndustyTypes(string IndustyTypesid)
			  {
					var jsonObjIndustyTypes = await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/getById_IndustyTypes?IndustyTypesid="+IndustyTypesid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
					if(jsonObjIndustyTypes.Length > 2)
					{
						jsonObjIndustyTypes = jsonObjIndustyTypes.Substring(1, jsonObjIndustyTypes.Length - 2);
						var model = JsonConvert.DeserializeObject<IndustyTypesModel>(jsonObjIndustyTypes);
						HttpContext.Session.SetSession("AIDataIndustyTypesModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='IndustyTypes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_IndustyTypes(IndustyTypesModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='IndustyTypes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("IndustyTypesid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_IndustyTypes";

							
							
							if(HttpContext.Session.GetString("AIDataloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("AIDataloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									IndustyTypesModelValidator validator = new IndustyTypesModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<IndustyTypesModel> ("AIDataIndustyTypesModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/IndustyTypes/Update_IndustyTypes", model);
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
                        _logger.LogError("Error occured in - IndustyTypes / Update_IndustyTypes , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_IndustyTypes(string IndustyTypesid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/Remove_IndustyTypes?IndustyTypesid="+IndustyTypesid+"&loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - IndustyTypes / Remove_IndustyTypes , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("AIDatarole_JSON") != null){
					DataTable AIDatarole_JSON =HttpContext.Session.GetSession<DataTable>("AIDataroles");
						 DataView dv = new DataView(AIDatarole_JSON);
						 dv.RowFilter = "controllername='IndustyTypes' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult IndustyTypes_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_IndustyTypes_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/IndustyTypes_List?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID")
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
											

				
			  public virtual async Task<string> getById_sp_all_IndustyTypes(string IndustyTypesid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/getById_sp_all_IndustyTypes?IndustyTypesid="+IndustyTypesid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_IndustyTypes_industryname()
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/IndustyTypes/lookup_IndustyTypes_industryname?loginUserID="+HttpContext.Session.GetString("AIDataloginUserID"));
			}





                    


				}


			}
