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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:42:42
				public class IndustyTypesController : Controller
				{
				public IndustyTypesController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<IndustyTypesController>();
					 _connectionSettings = connectionSettings;
					 objIndustyTypesDAL = new IndustyTypesDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private IndustyTypesDAL objIndustyTypesDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_IndustyTypes")]
            public virtual IActionResult Add_IndustyTypes([FromBody]IndustyTypesModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_IndustyTypes";
            try{

            if (ModelState.IsValid)
            {

            	IndustyTypesModelValidator validator = new IndustyTypesModelValidator();
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
		     

                                
            		                
                                   message = objIndustyTypesDAL.Add_IndustyTypes(model);
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

            	_logger.LogError("IndustyTypesModel - Add_IndustyTypes , Validation Error :" + message);
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
			  [ActionName("getById_IndustyTypes")]
			  public virtual System.Data.DataTable getById_IndustyTypes(string IndustyTypesid,string loginUserID="")
			  { 
				    DataTable dtIndustyTypes = new DataTable();
					try
					{
						  dtIndustyTypes = objIndustyTypesDAL.getById_IndustyTypes(IndustyTypesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtIndustyTypes;

			  }
			  [HttpPost()]
			  [ActionName("Update_IndustyTypes")]
			  public virtual IActionResult Update_IndustyTypes([FromBody]IndustyTypesModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_IndustyTypes";

					try{

					if (ModelState.IsValid)
					{

						IndustyTypesModelValidator validator = new IndustyTypesModelValidator();
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

		       
                                	
							    message = objIndustyTypesDAL.Update_IndustyTypes(model);	
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

						_logger.LogError("IndustyTypesModel - Update_IndustyTypes, Validation Error :" + message);
					
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
            public virtual string Remove_IndustyTypes(string IndustyTypesid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_IndustyTypes";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objIndustyTypesDAL.Remove_IndustyTypes(IndustyTypesid,loginUserID);
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
			
			[ActionName("IndustyTypes_List")]
			public virtual System.Data.DataTable IndustyTypes_List(string loginUserID="")
			{
					 
				  	DataTable dtIndustyTypes = new DataTable();
					try
					{
						dtIndustyTypes = objIndustyTypesDAL.IndustyTypes_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtIndustyTypes;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_IndustyTypes")]
			public virtual System.Data.DataTable get_all_IndustyTypes(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtIndustyTypes = new DataTable();
					try
					{
						dtIndustyTypes = objIndustyTypesDAL.get_all_IndustyTypes(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtIndustyTypes;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_IndustyTypes")]
			  public virtual System.Data.DataSet getById_sp_all_IndustyTypes(string IndustyTypesid)
			  { 
				    DataSet dsIndustyTypes = new DataSet();
					try
					{
						  dsIndustyTypes = objIndustyTypesDAL.getById_sp_all_IndustyTypes(IndustyTypesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsIndustyTypes;

			  }
[HttpGet()]
							[ActionName("lookup_IndustyTypes_industryname")]
							public virtual System.Data.DataTable lookup_IndustyTypes_industryname(string loginUserID="")
							{
									DataTable dtIndustyTypes = new DataTable();
									try
									{
										dtIndustyTypes = objIndustyTypesDAL.lookup_IndustyTypes_industryname();
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtIndustyTypes;
							}







				}


			}
