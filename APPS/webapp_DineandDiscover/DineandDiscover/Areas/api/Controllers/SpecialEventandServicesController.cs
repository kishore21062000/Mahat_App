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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 14:54:50
				public class SpecialEventandServicesController : Controller
				{
				public SpecialEventandServicesController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<SpecialEventandServicesController>();
					 _connectionSettings = connectionSettings;
					 objSpecialEventandServicesDAL = new SpecialEventandServicesDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private SpecialEventandServicesDAL objSpecialEventandServicesDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_Special_Event_and_Services")]
            public virtual IActionResult Add_Special_Event_and_Services([FromBody]SpecialEventandServicesModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_Special_Event_and_Services";
            try{

            if (ModelState.IsValid)
            {

            	SpecialEventandServicesModelValidator validator = new SpecialEventandServicesModelValidator();
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
		     

                                
            		                
                                   message = objSpecialEventandServicesDAL.Add_Special_Event_and_Services(model);
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

            	_logger.LogError("SpecialEventandServicesModel - Add_Special_Event_and_Services , Validation Error :" + message);
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
			  [ActionName("getById_SpecialEventandServices")]
			  public virtual System.Data.DataTable getById_SpecialEventandServices(string SpecialEventandServicesid,string loginUserID="")
			  { 
				    DataTable dtSpecialEventandServices = new DataTable();
					try
					{
						  dtSpecialEventandServices = objSpecialEventandServicesDAL.getById_SpecialEventandServices(SpecialEventandServicesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtSpecialEventandServices;

			  }
			  [HttpPost()]
			  [ActionName("Update_Special_Event_and_Services")]
			  public virtual IActionResult Update_Special_Event_and_Services([FromBody]SpecialEventandServicesModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Special_Event_and_Services";

					try{

					if (ModelState.IsValid)
					{

						SpecialEventandServicesModelValidator validator = new SpecialEventandServicesModelValidator();
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

		       
                                	
							    message = objSpecialEventandServicesDAL.Update_Special_Event_and_Services(model);	
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

						_logger.LogError("SpecialEventandServicesModel - Update_Special_Event_and_Services, Validation Error :" + message);
					
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
            public virtual string Remove_Special_Event_and_Services(string SpecialEventandServicesid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_Special_Event_and_Services";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objSpecialEventandServicesDAL.Remove_Special_Event_and_Services(SpecialEventandServicesid,loginUserID);
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
			
			[ActionName("Special_Event_and_Services_List")]
			public virtual System.Data.DataTable Special_Event_and_Services_List(string loginUserID="")
			{
					 
				  	DataTable dtSpecialEventandServices = new DataTable();
					try
					{
						dtSpecialEventandServices = objSpecialEventandServicesDAL.Special_Event_and_Services_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtSpecialEventandServices;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_SpecialEventandServices")]
			public virtual System.Data.DataTable get_all_SpecialEventandServices(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtSpecialEventandServices = new DataTable();
					try
					{
						dtSpecialEventandServices = objSpecialEventandServicesDAL.get_all_SpecialEventandServices(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtSpecialEventandServices;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_SpecialEventandServices")]
			  public virtual System.Data.DataSet getById_sp_all_SpecialEventandServices(string SpecialEventandServicesid)
			  { 
				    DataSet dsSpecialEventandServices = new DataSet();
					try
					{
						  dsSpecialEventandServices = objSpecialEventandServicesDAL.getById_sp_all_SpecialEventandServices(SpecialEventandServicesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsSpecialEventandServices;

			  }
[HttpGet()]
							[ActionName("lookup_SpecialEventandServices_specialeventandservices")]
							public virtual System.Data.DataTable lookup_SpecialEventandServices_specialeventandservices(String tenantid,string loginUserID="")
							{
									DataTable dtSpecialEventandServices = new DataTable();
									try
									{
										dtSpecialEventandServices = objSpecialEventandServicesDAL.lookup_SpecialEventandServices_specialeventandservices(tenantid);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtSpecialEventandServices;
							}







				}


			}
