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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/17/2023 08:36:16
				public class specialfeaturesavailController : Controller
				{
				public specialfeaturesavailController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<specialfeaturesavailController>();
					 _connectionSettings = connectionSettings;
					 objspecialfeaturesavailDAL = new specialfeaturesavailDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private specialfeaturesavailDAL objspecialfeaturesavailDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_specialfeatures_avail")]
            public virtual IActionResult Add_specialfeatures_avail([FromBody]specialfeaturesavailModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_specialfeatures_avail";
            try{

            if (ModelState.IsValid)
            {

            	specialfeaturesavailModelValidator validator = new specialfeaturesavailModelValidator();
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
		     

                                
            		                
                                   message = objspecialfeaturesavailDAL.Add_specialfeatures_avail(model);
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

            	_logger.LogError("specialfeaturesavailModel - Add_specialfeatures_avail , Validation Error :" + message);
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
			  [ActionName("getById_specialfeaturesavail")]
			  public virtual System.Data.DataTable getById_specialfeaturesavail(string specialfeaturesavailid,string loginUserID="")
			  { 
				    DataTable dtspecialfeaturesavail = new DataTable();
					try
					{
						  dtspecialfeaturesavail = objspecialfeaturesavailDAL.getById_specialfeaturesavail(specialfeaturesavailid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtspecialfeaturesavail;

			  }
			  [HttpPost()]
			  [ActionName("Update_specialfeatures_avail")]
			  public virtual IActionResult Update_specialfeatures_avail([FromBody]specialfeaturesavailModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_specialfeatures_avail";

					try{

					if (ModelState.IsValid)
					{

						specialfeaturesavailModelValidator validator = new specialfeaturesavailModelValidator();
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

		       
                                	
							    message = objspecialfeaturesavailDAL.Update_specialfeatures_avail(model);	
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

						_logger.LogError("specialfeaturesavailModel - Update_specialfeatures_avail, Validation Error :" + message);
					
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
            public virtual string Remove_specialfeatures_avail(string specialfeaturesavailid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_specialfeatures_avail";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objspecialfeaturesavailDAL.Remove_specialfeatures_avail(specialfeaturesavailid,loginUserID);
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
			
			[ActionName("specialfeatures_avail_List")]
			public virtual System.Data.DataTable specialfeatures_avail_List(string loginUserID="")
			{
					 
				  	DataTable dtspecialfeaturesavail = new DataTable();
					try
					{
						dtspecialfeaturesavail = objspecialfeaturesavailDAL.specialfeatures_avail_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtspecialfeaturesavail;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_specialfeaturesavail")]
			public virtual System.Data.DataTable get_all_specialfeaturesavail(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtspecialfeaturesavail = new DataTable();
					try
					{
						dtspecialfeaturesavail = objspecialfeaturesavailDAL.get_all_specialfeaturesavail(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtspecialfeaturesavail;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_specialfeaturesavail")]
			  public virtual System.Data.DataSet getById_sp_all_specialfeaturesavail(string specialfeaturesavailid)
			  { 
				    DataSet dsspecialfeaturesavail = new DataSet();
					try
					{
						  dsspecialfeaturesavail = objspecialfeaturesavailDAL.getById_sp_all_specialfeaturesavail(specialfeaturesavailid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsspecialfeaturesavail;

			  }
[HttpGet()]
							[ActionName("lookup_specialfeaturesavail_specialfeaturesavail")]
							public virtual System.Data.DataTable lookup_specialfeaturesavail_specialfeaturesavail(String tenantid,string loginUserID="")
							{
									DataTable dtspecialfeaturesavail = new DataTable();
									try
									{
										dtspecialfeaturesavail = objspecialfeaturesavailDAL.lookup_specialfeaturesavail_specialfeaturesavail(tenantid);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtspecialfeaturesavail;
							}







				}


			}
