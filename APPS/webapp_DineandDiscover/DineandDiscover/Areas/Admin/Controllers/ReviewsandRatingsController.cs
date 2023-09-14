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
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:50:43
				
                [Area("Admin")]
                
				public class ReviewsandRatingsController : Controller
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
                    private readonly ILogger<ReviewsandRatingsController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("DineandDiscovertoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public ReviewsandRatingsController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<ReviewsandRatingsController> logger)
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

	

					
			  public virtual IActionResult Add_Reviews_and_Ratings()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_Reviews_and_Ratings(ReviewsandRatingsModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("ReviewsandRatingsid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_Reviews_and_Ratings";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='ReviewsandRatings' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 ReviewsandRatingsModelValidator validator = new ReviewsandRatingsModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/ReviewsandRatings/Add_Reviews_and_Ratings", model);
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
                _logger.LogError("Error occured in - ReviewsandRatings / Add_Reviews_and_Ratings , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_Reviews_and_Ratings(string ReviewsandRatingsid)
			  {
					var jsonObjReviewsandRatings = await ApiClient.Get_ApiValues(getHttpClient(), "api/ReviewsandRatings/getById_ReviewsandRatings?ReviewsandRatingsid="+ReviewsandRatingsid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					if(jsonObjReviewsandRatings.Length > 2)
					{
						jsonObjReviewsandRatings = jsonObjReviewsandRatings.Substring(1, jsonObjReviewsandRatings.Length - 2);
						var model = JsonConvert.DeserializeObject<ReviewsandRatingsModel>(jsonObjReviewsandRatings);
						HttpContext.Session.SetSession("DineandDiscoverReviewsandRatingsModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='ReviewsandRatings' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_Reviews_and_Ratings(ReviewsandRatingsModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='ReviewsandRatings' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("ReviewsandRatingsid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_Reviews_and_Ratings";

							
							
							if(HttpContext.Session.GetString("DineandDiscoverloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("DineandDiscoverloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									ReviewsandRatingsModelValidator validator = new ReviewsandRatingsModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<ReviewsandRatingsModel> ("DineandDiscoverReviewsandRatingsModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/ReviewsandRatings/Update_Reviews_and_Ratings", model);
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
                        _logger.LogError("Error occured in - ReviewsandRatings / Update_Reviews_and_Ratings , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_Reviews_and_Ratings(string ReviewsandRatingsid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/ReviewsandRatings/Remove_Reviews_and_Ratings?ReviewsandRatingsid="+ReviewsandRatingsid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - ReviewsandRatings / Remove_Reviews_and_Ratings , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("DineandDiscoverrole_JSON") != null){
					DataTable DineandDiscoverrole_JSON =HttpContext.Session.GetSession<DataTable>("DineandDiscoverroles");
						 DataView dv = new DataView(DineandDiscoverrole_JSON);
						 dv.RowFilter = "controllername='ReviewsandRatings' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult Reviews_and_Ratings_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_Reviews_and_Ratings_List()
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/ReviewsandRatings/Reviews_and_Ratings_List?loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID")
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
											

				
			  public virtual async Task<string> getById_sp_all_ReviewsandRatings(string ReviewsandRatingsid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/ReviewsandRatings/getById_sp_all_ReviewsandRatings?ReviewsandRatingsid="+ReviewsandRatingsid);
					 
			  }
[HttpGet()]
			public virtual async Task<string> lookup_ReviewsandRatings_reviewsandratings(String tenantid)
			{
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/ReviewsandRatings/lookup_ReviewsandRatings_reviewsandratings?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("DineandDiscoverloginUserID"));
			}





                    


				}


			}
