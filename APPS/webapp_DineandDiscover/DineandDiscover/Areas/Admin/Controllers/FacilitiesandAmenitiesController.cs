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
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 14:04:15
				
                [Area("Admin")]
                
				public class FacilitiesandAmenitiesController : Controller
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
                    private readonly ILogger<FacilitiesandAmenitiesController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("DineandDiscovertoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public FacilitiesandAmenitiesController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<FacilitiesandAmenitiesController> logger)
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

	

					
			  public virtual IActionResult Add_Facilities_and_Amenities()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Facilities_and_Amenities(FacilitiesandAmenitiesModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("FacilitiesandAmenitiesid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Facilities_and_Amenities";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='FacilitiesandAmenities' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 FacilitiesandAmenitiesModelValidator validator = new FacilitiesandAmenitiesModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/FacilitiesandAmenities/Add_Facilities_and_Amenities", model);
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
                _logger.LogError("Error occured in - FacilitiesandAmenities / Add_Facilities_and_Amenities , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_Facilities_and_Amenities(string FacilitiesandAmenitiesid)
			  {
					var jsonObjFacilitiesandAmenities = await ApiClient.Get_ApiValues(getHttpClient(), "api/FacilitiesandAmenities/getById_FacilitiesandAmenities?FacilitiesandAmenitiesid="+FacilitiesandAmenitiesid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					if(jsonObjFacilitiesandAmenities.Length > 2)
					{
						jsonObjFacilitiesandAmenities = jsonObjFacilitiesandAmenities.Substring(1, jsonObjFacilitiesandAmenities.Length - 2);
						var model = JsonConvert.DeserializeObject<FacilitiesandAmenitiesModel>(jsonObjFacilitiesandAmenities);
						HttpContext.Session.SetSession("DineandDiscoverFacilitiesandAmenitiesModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='FacilitiesandAmenities' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Facilities_and_Amenities(FacilitiesandAmenitiesModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='FacilitiesandAmenities' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("FacilitiesandAmenitiesid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Facilities_and_Amenities";

							
							
							if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									FacilitiesandAmenitiesModelValidator validator = new FacilitiesandAmenitiesModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<FacilitiesandAmenitiesModel> ("DineandDiscoverFacilitiesandAmenitiesModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/FacilitiesandAmenities/Update_Facilities_and_Amenities", model);
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
                        _logger.LogError("Error occured in - FacilitiesandAmenities / Update_Facilities_and_Amenities , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_Facilities_and_Amenities(string FacilitiesandAmenitiesid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/FacilitiesandAmenities/Remove_Facilities_and_Amenities?FacilitiesandAmenitiesid="+FacilitiesandAmenitiesid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - FacilitiesandAmenities / Remove_Facilities_and_Amenities , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='FacilitiesandAmenities' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Facilities_and_Amenities_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Facilities_and_Amenities_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/FacilitiesandAmenities/Facilities_and_Amenities_List?loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID")
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
											

				
			  public virtual async Task<string> getById_sp_all_FacilitiesandAmenities(string FacilitiesandAmenitiesid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/FacilitiesandAmenities/getById_sp_all_FacilitiesandAmenities?FacilitiesandAmenitiesid="+FacilitiesandAmenitiesid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_FacilitiesandAmenities_facilitiesandamenities(String tenantid)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/FacilitiesandAmenities/lookup_FacilitiesandAmenities_facilitiesandamenities?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
			}





                    


				}


			}
