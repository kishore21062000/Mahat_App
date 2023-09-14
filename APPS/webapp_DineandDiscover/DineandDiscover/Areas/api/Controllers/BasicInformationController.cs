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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 14:17:42
				public class BasicInformationController : Controller
				{
				public BasicInformationController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<BasicInformationController>();
					 _connectionSettings = connectionSettings;
					 objBasicInformationDAL = new BasicInformationDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private BasicInformationDAL objBasicInformationDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_Basic_Information")]
            public virtual IActionResult Add_Basic_Information([FromBody]BasicInformationModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_Basic_Information";
            try{

            if (ModelState.IsValid)
            {

            	BasicInformationModelValidator validator = new BasicInformationModelValidator();
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
		     

                                
            		                
                                   message = objBasicInformationDAL.Add_Basic_Information(model);
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

            	_logger.LogError("BasicInformationModel - Add_Basic_Information , Validation Error :" + message);
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
			  [ActionName("getById_BasicInformation")]
			  public virtual System.Data.DataTable getById_BasicInformation(string BasicInformationid,string loginUserID="")
			  { 
				    DataTable dtBasicInformation = new DataTable();
					try
					{
						  dtBasicInformation = objBasicInformationDAL.getById_BasicInformation(BasicInformationid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtBasicInformation;

			  }
			  [HttpPost()]
			  [ActionName("Update_Basic_Information")]
			  public virtual IActionResult Update_Basic_Information([FromBody]BasicInformationModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Basic_Information";

					try{

					if (ModelState.IsValid)
					{

						BasicInformationModelValidator validator = new BasicInformationModelValidator();
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

		       
                                	
							    message = objBasicInformationDAL.Update_Basic_Information(model);	
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

						_logger.LogError("BasicInformationModel - Update_Basic_Information, Validation Error :" + message);
					
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
            public virtual string Remove_Basic_Information(string BasicInformationid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_Basic_Information";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objBasicInformationDAL.Remove_Basic_Information(BasicInformationid,loginUserID);
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
			
			[ActionName("Basic_Information_List")]
			public virtual System.Data.DataTable Basic_Information_List(string tenantid
,string loginUserID="")
			{
					 
				  	DataTable dtBasicInformation = new DataTable();
					try
					{
						dtBasicInformation = objBasicInformationDAL.Basic_Information_List( tenantid
);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtBasicInformation;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_BasicInformation")]
			public virtual System.Data.DataTable get_all_BasicInformation(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtBasicInformation = new DataTable();
					try
					{
						dtBasicInformation = objBasicInformationDAL.get_all_BasicInformation(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtBasicInformation;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_BasicInformation")]
			  public virtual System.Data.DataSet getById_sp_all_BasicInformation(string BasicInformationid)
			  { 
				    DataSet dsBasicInformation = new DataSet();
					try
					{
						  dsBasicInformation = objBasicInformationDAL.getById_sp_all_BasicInformation(BasicInformationid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsBasicInformation;

			  }







				}


			}
