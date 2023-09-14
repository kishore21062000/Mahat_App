namespace AIDataWebApi.Controllers
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
				using AIData.Models;
				using AIData.DAL;
				using FluentValidation.Results;

				using Microsoft.AspNetCore.Hosting;
				using System.IO;
				using System.Net.Http.Headers;
				[Authorize()]
				[Route("api/[controller]/[action]")]
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:44:55
				public class SubTypesController : Controller
				{
				public SubTypesController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<SubTypesController>();
					 _connectionSettings = connectionSettings;
					 objSubTypesDAL = new SubTypesDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private SubTypesDAL objSubTypesDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_SubTypes")]
            public virtual IActionResult Add_SubTypes([FromBody]SubTypesModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_SubTypes";
            try{

            if (ModelState.IsValid)
            {

            	SubTypesModelValidator validator = new SubTypesModelValidator();
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
		     

                                
            		                
                                   message = objSubTypesDAL.Add_SubTypes(model);
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

            	_logger.LogError("SubTypesModel - Add_SubTypes , Validation Error :" + message);
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
			  [ActionName("getById_SubTypes")]
			  public virtual System.Data.DataTable getById_SubTypes(string SubTypesid,string loginUserID="")
			  { 
				    DataTable dtSubTypes = new DataTable();
					try
					{
						  dtSubTypes = objSubTypesDAL.getById_SubTypes(SubTypesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtSubTypes;

			  }
			  [HttpPost()]
			  [ActionName("Update_SubTypes")]
			  public virtual IActionResult Update_SubTypes([FromBody]SubTypesModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_SubTypes";

					try{

					if (ModelState.IsValid)
					{

						SubTypesModelValidator validator = new SubTypesModelValidator();
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

		       
                                	
							    message = objSubTypesDAL.Update_SubTypes(model);	
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

						_logger.LogError("SubTypesModel - Update_SubTypes, Validation Error :" + message);
					
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
            public virtual string Remove_SubTypes(string SubTypesid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_SubTypes";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objSubTypesDAL.Remove_SubTypes(SubTypesid,loginUserID);
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
			
			[ActionName("SubTypes_List")]
			public virtual System.Data.DataTable SubTypes_List(string loginUserID="")
			{
					 
				  	DataTable dtSubTypes = new DataTable();
					try
					{
						dtSubTypes = objSubTypesDAL.SubTypes_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtSubTypes;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_SubTypes")]
			public virtual System.Data.DataTable get_all_SubTypes(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtSubTypes = new DataTable();
					try
					{
						dtSubTypes = objSubTypesDAL.get_all_SubTypes(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtSubTypes;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_SubTypes")]
			  public virtual System.Data.DataSet getById_sp_all_SubTypes(string SubTypesid)
			  { 
				    DataSet dsSubTypes = new DataSet();
					try
					{
						  dsSubTypes = objSubTypesDAL.getById_sp_all_SubTypes(SubTypesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsSubTypes;

			  }
[HttpGet()]
							[ActionName("lookup_SubTypes_industryname")]
							public virtual System.Data.DataTable lookup_SubTypes_industryname(string loginUserID="")
							{
									DataTable dtSubTypes = new DataTable();
									try
									{
										dtSubTypes = objSubTypesDAL.lookup_SubTypes_industryname();
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtSubTypes;
							}
[HttpGet()]
							[ActionName("lookup_SubTypes_industrytypename")]
							public virtual System.Data.DataTable lookup_SubTypes_industrytypename(String industryname,string loginUserID="")
							{
									DataTable dtSubTypes = new DataTable();
									try
									{
										dtSubTypes = objSubTypesDAL.lookup_SubTypes_industrytypename(industryname);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtSubTypes;
							}







				}


			}
