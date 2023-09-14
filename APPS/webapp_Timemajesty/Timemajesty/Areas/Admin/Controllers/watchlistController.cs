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
				using Timemajesty.Models;
				using Microsoft.AspNetCore.Mvc.Infrastructure;
				using Microsoft.AspNetCore.HttpOverrides;
                using Microsoft.Extensions.Configuration;
                using Microsoft.Extensions.Logging;
                
                
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/25/2023 09:04:38
				
                [Area("Admin")]
                
				public class watchlistController : Controller
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
                    private readonly ILogger<watchlistController> _logger;
                    
					public virtual HttpClient getHttpClient()
					{
						client.BaseAddress = new Uri(url);
						client.DefaultRequestHeaders.Accept.Clear();
						client.DefaultRequestHeaders.Add("Authorization", "Bearer " + HttpContext.Session.GetString("Timemajestytoken")); 
						client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
						return client; 
					}
					public watchlistController(IConfiguration configuration,IHttpContextAccessor accessor,IOptions<ApiSettings> ApiSettings, IOptions<MailSettings> MailSettings, IWebHostEnvironment env, ILogger<watchlistController> logger)
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

	

					
			  public virtual IActionResult Add_watchlist()
			  {
					return View();
			  }	
			  [HttpPost()]
			public virtual async Task<IActionResult> Add_watchlist(watchlistModel model, IFormCollection collection)
			{
				string strReturnMessage = "";
				string redirectTo="";
				try
				{
					ModelState.Remove("watchlistid");
                    ModelState.Remove("craftmyapp_actionmethodname");
                    model.craftmyapp_actionmethodname="Add_watchlist";
					ModelState.Remove("createduser");
					if(HttpContext.Session.GetString("TimemajestyloginUserID") != null)
						model.createduser =new Guid(HttpContext.Session.GetString("TimemajestyloginUserID"));
						else
						return RedirectToAction(redirectTo);
					
					

					if(HttpContext.Session.GetString("Timemajestyrole_JSON") != null){
					DataTable Timemajestyrole_JSON =HttpContext.Session.GetSession<DataTable>("Timemajestyroles");
						 DataView dv = new DataView(Timemajestyrole_JSON);
						 dv.RowFilter = "controllername='watchlist' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
			 	 
					 if (ModelState.IsValid)
					 {
							 watchlistModelValidator validator = new watchlistModelValidator();
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
								 
								 
								 strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/watchlist/Add_watchlist", model);
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
                _logger.LogError("Error occured in - watchlist / Add_watchlist , Error Message : " + ex.Message);
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

				
			  public virtual async Task<IActionResult> Update_watchlist(string watchlistid)
			  {
					var jsonObjwatchlist = await ApiClient.Get_ApiValues(getHttpClient(), "api/watchlist/getById_watchlist?watchlistid="+watchlistid+"&loginUserID="+HttpContext.Session.GetString("TimemajestyloginUserID"));
					if(jsonObjwatchlist.Length > 2)
					{
						jsonObjwatchlist = jsonObjwatchlist.Substring(1, jsonObjwatchlist.Length - 2);
						var model = JsonConvert.DeserializeObject<watchlistModel>(jsonObjwatchlist);
						HttpContext.Session.SetSession("TimemajestywatchlistModel", model);
						return View(model);
					}
					else
					{
						string redirectTo="";
						if(HttpContext.Session.GetString("Timemajestyrole_JSON") != null){
					DataTable Timemajestyrole_JSON =HttpContext.Session.GetSession<DataTable>("Timemajestyroles");
						 DataView dv = new DataView(Timemajestyrole_JSON);
						 dv.RowFilter = "controllername='watchlist' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
						TempData["message"] = "Data Not Found - Contact Administrator";
						return RedirectToAction(redirectTo);
						 
					}
			  }	
			  [HttpPost()]
				public virtual async Task<IActionResult> Update_watchlist(watchlistModel model, IFormCollection collection)
				{
					string strReturnMessage = "";
					string redirectTo="";
					try
					{
						
						if(HttpContext.Session.GetString("Timemajestyrole_JSON") != null){
					DataTable Timemajestyrole_JSON =HttpContext.Session.GetSession<DataTable>("Timemajestyroles");
						 DataView dv = new DataView(Timemajestyrole_JSON);
						 dv.RowFilter = "controllername='watchlist' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}

							 ModelState.Remove("watchlistid");
                             ModelState.Remove("craftmyapp_actionmethodname");
                             model.craftmyapp_actionmethodname="Update_watchlist";

							
							
							if(HttpContext.Session.GetString("TimemajestyloginUserID") != null)
					model.modifieduser =new Guid(HttpContext.Session.GetString("TimemajestyloginUserID"));
					else
					return RedirectToAction(redirectTo);
							
                            
							if (ModelState.IsValid)
							{
									watchlistModelValidator validator = new watchlistModelValidator();
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
										
                                        var modelCopy = HttpContext.Session.GetSession<watchlistModel> ("TimemajestywatchlistModel");

										strReturnMessage = await ApiClient.Post_ApiValuesGetString(getHttpClient(),"api/watchlist/Update_watchlist", model);
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
                        _logger.LogError("Error occured in - watchlist / Update_watchlist , Error Message : " + ex.Message);
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
public virtual async Task<IActionResult> Remove_watchlist(string watchlistid)
			{
				string message = "";
				try
				{
						message = await ApiClient.Get_ApiValues(getHttpClient(), "api/watchlist/Remove_watchlist?watchlistid="+watchlistid+"&loginUserID="+HttpContext.Session.GetString("TimemajestyloginUserID"));

						 if(message.Replace("\"","")=="201.1")
						{
							TempData["message"] = "Success";

						}else{
							TempData["errMessage"] = message.Replace("\"","");
						}
						
				
				
				}
				catch (Exception ex)
				{
                    _logger.LogError("Error occured in - watchlist / Remove_watchlist , Error Message : " + ex.Message);
Console.WriteLine(ex);
					 TempData["errMessage"] = ex.Message;
					 message = ex.Message;
				}

				string redirectTo="";
						if(HttpContext.Session.GetString("Timemajestyrole_JSON") != null){
					DataTable Timemajestyrole_JSON =HttpContext.Session.GetSession<DataTable>("Timemajestyroles");
						 DataView dv = new DataView(Timemajestyrole_JSON);
						 dv.RowFilter = "controllername='watchlist' AND viewname='list'";

						if(dv.Count  >0){
						    redirectTo = dv[0]["actionmethodname"] as string;
							 
						}

					}
				
				return RedirectToAction(redirectTo);
			}

			public virtual IActionResult watchlist_List()
			{
				return View();
			}
				
			[HttpGet()]
			public virtual async Task<string> get_watchlist_List(string tenantid
)
			{
				
				return await ApiClient.Get_ApiValues(getHttpClient(), "api/watchlist/watchlist_List?tenantid="+tenantid+"&loginUserID="+HttpContext.Session.GetString("TimemajestyloginUserID")
);
			}
			 

				
			  public virtual async Task<string> getById_sp_all_watchlist(string watchlistid)
			  {
					return await ApiClient.Get_ApiValues(getHttpClient(), "api/watchlist/getById_sp_all_watchlist?watchlistid="+watchlistid);
					 
			  }





                    


				}


			}