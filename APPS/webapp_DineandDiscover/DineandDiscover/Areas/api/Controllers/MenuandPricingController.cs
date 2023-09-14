namespace DineandDiscoverWebApi.Controllers
			{
				using System;
				using System.Data;
				using System.Linq;
				using Microsoft.AspNetCore.Mvc;
				using System.Collections.Generic;
				using Microsoft.Extensions.Options;
				using Microsoft.Extensions.Logging;
				using Microsoft.AspNetCore.Authorization;
				using Microsoft.Extensions.Configuration;
				using System.IdentityModel.Tokens.Jwt;
				using System.Security.Claims;
				using System.Text;
				using Microsoft.IdentityModel.Tokens;
				using DineandDiscover.Models;
				using DineandDiscover.DAL;
				using FluentValidation.Results;

				using Microsoft.AspNetCore.Hosting;
				using System.IO;
				using System.Net.Http.Headers;
				[Authorize()]
				[Area("api")]  [Route("api/[controller]/[action]")]
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:36:11
				public class MenuandPricingController : Controller
				{
				public MenuandPricingController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<MenuandPricingController>();
					 _connectionSettings = connectionSettings;
					 objMenuandPricingDAL = new MenuandPricingDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private MenuandPricingDAL objMenuandPricingDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_Menu_and_Pricing")]
            public virtual IActionResult Add_Menu_and_Pricing([FromBody]MenuandPricingModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_Menu_and_Pricing";
            try{

            if (ModelState.IsValid)
            {

            	MenuandPricingModelValidator validator = new MenuandPricingModelValidator();
            	ValidationResult results = validator.Validate(model);
            	if (!results.IsValid)
            	{
            		var errorCollection = string.Join(" | ", results.Errors.Select(e => e.ErrorMessage.Replace("{propertyName}",e.PropertyName)));
             		message = ("Validation Error : " + errorCollection);


            	}else{

                                   var authHeader = HttpContext.Request.Headers["Authorization"][0];
                                if (authHeader.StartsWith("Bearer "))
                                {
                                 var token = authHeader.Substring("Bearer ".Length);
                                String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        model.createduser=new Guid(userdetails[0].ToString());
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		     

                                
            		                
                                   message = objMenuandPricingDAL.Add_Menu_and_Pricing(model);
                               }
                                else{
                                  message = "Invalid Token";
                                 }

            	}


            }
            else
            {
            	var errorCollection = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
            	message = errorCollection.ToString();

            	_logger.LogError("MenuandPricingModel - Add_Menu_and_Pricing , Validation Error :" + message);
            	message = ("Validation Error : " + message);
            }






            }catch(Exception ex){
            	message=ex.Message;
            	_logger.LogError(ex.Message);
            	message = ("Exception : " + ex.Message);
            }

            obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
            obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);
                     

            if(message.Replace("\"","").Contains("201.1"))
            return Ok(message);
            else if(message.Replace("\"","")=="401.1")
            return Unauthorized(message);
            else
            return BadRequest("DB Exception : " +message);
             }
[HttpGet()]
			  [ActionName("getById_MenuandPricing")]
			  public virtual System.Data.DataTable getById_MenuandPricing(string MenuandPricingid,string loginUserID="")
			  { 
				    DataTable dtMenuandPricing = new DataTable();
					try
					{
						  dtMenuandPricing = objMenuandPricingDAL.getById_MenuandPricing(MenuandPricingid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtMenuandPricing;

			  }
			  [HttpPost()]
			  [ActionName("Update_Menu_and_Pricing")]
			  public virtual IActionResult Update_Menu_and_Pricing([FromBody]MenuandPricingModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Menu_and_Pricing";

					try{

					if (ModelState.IsValid)
					{

						MenuandPricingModelValidator validator = new MenuandPricingModelValidator();
						ValidationResult results = validator.Validate(model);
						if (!results.IsValid)
						{
							var errorCollection = string.Join(" | ", results.Errors.Select(e => e.ErrorMessage.Replace("{propertyName}",e.PropertyName)));
							message = errorCollection.ToString();
							//return BadRequest("Validation Error : " + message);

						}else{
                            var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                      
                                var token = authHeader.Substring("Bearer ".Length);
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
                                model.modifieduser=new Guid(userdetails[0].ToString());
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());

		       
                                	
							    message = objMenuandPricingDAL.Update_Menu_and_Pricing(model);	
                            }
                            else{
                                message = "Invalid Token";
                                 
                            }
							
						}


					}
					else
					{
						var errorCollection = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
						message = errorCollection.ToString();

						_logger.LogError("MenuandPricingModel - Update_Menu_and_Pricing, Validation Error :" + message);
					
						//return BadRequest("Validation Error : " + message);
					}






					}catch(Exception ex){
						message=ex.Message;
						_logger.LogError(ex.Message);
						//return BadRequest("Exception : " + ex.Message);
					}

                        obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
                       obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);

					if(message.Replace("\"","")=="201.1")
					return Ok(message);
					else if(message.Replace("\"","")=="401.1")
					return Unauthorized(message);
					else
					return BadRequest("DB Exception : " +message);

					


			   }
[HttpGet()]
            public virtual string Remove_Menu_and_Pricing(string MenuandPricingid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_Menu_and_Pricing";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objMenuandPricingDAL.Remove_Menu_and_Pricing(MenuandPricingid,loginUserID);
						    }
	                        else{
		                        message = "Invalid Token";
		                       
	                        }
					 

					}catch(Exception ex){
						message=ex.Message;
						_logger.LogError(ex.Message);
					}
				    obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
                    obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);
                 
					return message;

			}
[HttpGet()]
			
			[ActionName("Menu_and_Pricing_List")]
			public virtual System.Data.DataTable Menu_and_Pricing_List(string loginUserID="")
			{
					 
				  	DataTable dtMenuandPricing = new DataTable();
					try
					{
						dtMenuandPricing = objMenuandPricingDAL.Menu_and_Pricing_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtMenuandPricing;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_MenuandPricing")]
			public virtual System.Data.DataTable get_all_MenuandPricing(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtMenuandPricing = new DataTable();
					try
					{
						dtMenuandPricing = objMenuandPricingDAL.get_all_MenuandPricing(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtMenuandPricing;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_MenuandPricing")]
			  public virtual System.Data.DataSet getById_sp_all_MenuandPricing(string MenuandPricingid)
			  { 
				    DataSet dsMenuandPricing = new DataSet();
					try
					{
						  dsMenuandPricing = objMenuandPricingDAL.getById_sp_all_MenuandPricing(MenuandPricingid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsMenuandPricing;

			  }
[HttpGet()]
							[ActionName("lookup_MenuandPricing_menus")]
							public virtual System.Data.DataTable lookup_MenuandPricing_menus(String tenantid,string loginUserID="")
							{
									DataTable dtMenuandPricing = new DataTable();
									try
									{
										dtMenuandPricing = objMenuandPricingDAL.lookup_MenuandPricing_menus(tenantid);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtMenuandPricing;
							}







				}


			}
