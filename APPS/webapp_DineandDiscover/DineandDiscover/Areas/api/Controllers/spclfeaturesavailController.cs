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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/17/2023 11:18:01
				public class spclfeaturesavailController : Controller
				{
				public spclfeaturesavailController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<spclfeaturesavailController>();
					 _connectionSettings = connectionSettings;
					 objspclfeaturesavailDAL = new spclfeaturesavailDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private spclfeaturesavailDAL objspclfeaturesavailDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_specialfeatures_avail")]
            public virtual IActionResult Add_specialfeatures_avail([FromBody]spclfeaturesavailModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_specialfeatures_avail";
            try{

            if (ModelState.IsValid)
            {

            	spclfeaturesavailModelValidator validator = new spclfeaturesavailModelValidator();
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
		     

                                
            		                
                                   message = objspclfeaturesavailDAL.Add_specialfeatures_avail(model);
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

            	_logger.LogError("spclfeaturesavailModel - Add_specialfeatures_avail , Validation Error :" + message);
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
			  [ActionName("getById_spclfeaturesavail")]
			  public virtual System.Data.DataTable getById_spclfeaturesavail(string spclfeaturesavailid,string loginUserID="")
			  { 
				    DataTable dtspclfeaturesavail = new DataTable();
					try
					{
						  dtspclfeaturesavail = objspclfeaturesavailDAL.getById_spclfeaturesavail(spclfeaturesavailid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtspclfeaturesavail;

			  }
			  [HttpPost()]
			  [ActionName("Update_specialfeatures_avail")]
			  public virtual IActionResult Update_specialfeatures_avail([FromBody]spclfeaturesavailModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_specialfeatures_avail";

					try{

					if (ModelState.IsValid)
					{

						spclfeaturesavailModelValidator validator = new spclfeaturesavailModelValidator();
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

		       
                                	
							    message = objspclfeaturesavailDAL.Update_specialfeatures_avail(model);	
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

						_logger.LogError("spclfeaturesavailModel - Update_specialfeatures_avail, Validation Error :" + message);
					
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
            public virtual string Remove_specialfeatures_avail(string spclfeaturesavailid,string loginUserID="")
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
		                      
		       
                        	 message = objspclfeaturesavailDAL.Remove_specialfeatures_avail(spclfeaturesavailid,loginUserID);
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
					 
				  	DataTable dtspclfeaturesavail = new DataTable();
					try
					{
						dtspclfeaturesavail = objspclfeaturesavailDAL.specialfeatures_avail_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtspclfeaturesavail;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_spclfeaturesavail")]
			public virtual System.Data.DataTable get_all_spclfeaturesavail(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtspclfeaturesavail = new DataTable();
					try
					{
						dtspclfeaturesavail = objspclfeaturesavailDAL.get_all_spclfeaturesavail(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtspclfeaturesavail;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_spclfeaturesavail")]
			  public virtual System.Data.DataSet getById_sp_all_spclfeaturesavail(string spclfeaturesavailid)
			  { 
				    DataSet dsspclfeaturesavail = new DataSet();
					try
					{
						  dsspclfeaturesavail = objspclfeaturesavailDAL.getById_sp_all_spclfeaturesavail(spclfeaturesavailid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsspclfeaturesavail;

			  }
[HttpGet()]
							[ActionName("lookup_spclfeaturesavail_spclfeatures")]
							public virtual System.Data.DataTable lookup_spclfeaturesavail_spclfeatures(String tenantid,string loginUserID="")
							{
									DataTable dtspclfeaturesavail = new DataTable();
									try
									{
										dtspclfeaturesavail = objspclfeaturesavailDAL.lookup_spclfeaturesavail_spclfeatures(tenantid);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtspclfeaturesavail;
							}







				}


			}
