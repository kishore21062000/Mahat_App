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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:47:17
				public class FuncitonsController : Controller
				{
				public FuncitonsController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<FuncitonsController>();
					 _connectionSettings = connectionSettings;
					 objFuncitonsDAL = new FuncitonsDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private FuncitonsDAL objFuncitonsDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_Funcitons")]
            public virtual IActionResult Add_Funcitons([FromBody]FuncitonsModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_Funcitons";
            try{

            if (ModelState.IsValid)
            {

            	FuncitonsModelValidator validator = new FuncitonsModelValidator();
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
		     

                                
            		                
                                   message = objFuncitonsDAL.Add_Funcitons(model);
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

            	_logger.LogError("FuncitonsModel - Add_Funcitons , Validation Error :" + message);
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
			  [ActionName("getById_Funcitons")]
			  public virtual System.Data.DataTable getById_Funcitons(string Funcitonsid,string loginUserID="")
			  { 
				    DataTable dtFuncitons = new DataTable();
					try
					{
						  dtFuncitons = objFuncitonsDAL.getById_Funcitons(Funcitonsid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtFuncitons;

			  }
			  [HttpPost()]
			  [ActionName("Update_Funcitons")]
			  public virtual IActionResult Update_Funcitons([FromBody]FuncitonsModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Funcitons";

					try{

					if (ModelState.IsValid)
					{

						FuncitonsModelValidator validator = new FuncitonsModelValidator();
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

		       
                                	
							    message = objFuncitonsDAL.Update_Funcitons(model);	
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

						_logger.LogError("FuncitonsModel - Update_Funcitons, Validation Error :" + message);
					
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
            public virtual string Remove_Funcitons(string Funcitonsid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_Funcitons";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objFuncitonsDAL.Remove_Funcitons(Funcitonsid,loginUserID);
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
			
			[ActionName("Funcitons_List")]
			public virtual System.Data.DataTable Funcitons_List(string loginUserID="")
			{
					 
				  	DataTable dtFuncitons = new DataTable();
					try
					{
						dtFuncitons = objFuncitonsDAL.Funcitons_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtFuncitons;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_Funcitons")]
			public virtual System.Data.DataTable get_all_Funcitons(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtFuncitons = new DataTable();
					try
					{
						dtFuncitons = objFuncitonsDAL.get_all_Funcitons(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtFuncitons;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_Funcitons")]
			  public virtual System.Data.DataSet getById_sp_all_Funcitons(string Funcitonsid)
			  { 
				    DataSet dsFuncitons = new DataSet();
					try
					{
						  dsFuncitons = objFuncitonsDAL.getById_sp_all_Funcitons(Funcitonsid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsFuncitons;

			  }
[HttpGet()]
							[ActionName("lookup_Funcitons_industryname")]
							public virtual System.Data.DataTable lookup_Funcitons_industryname(string loginUserID="")
							{
									DataTable dtFuncitons = new DataTable();
									try
									{
										dtFuncitons = objFuncitonsDAL.lookup_Funcitons_industryname();
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtFuncitons;
							}
[HttpGet()]
							[ActionName("lookup_Funcitons_industrytypename")]
							public virtual System.Data.DataTable lookup_Funcitons_industrytypename(String industryname,string loginUserID="")
							{
									DataTable dtFuncitons = new DataTable();
									try
									{
										dtFuncitons = objFuncitonsDAL.lookup_Funcitons_industrytypename(industryname);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtFuncitons;
							}
[HttpGet()]
							[ActionName("lookup_Funcitons_subtypename")]
							public virtual System.Data.DataTable lookup_Funcitons_subtypename(String industryname,String industrytypename,string loginUserID="")
							{
									DataTable dtFuncitons = new DataTable();
									try
									{
										dtFuncitons = objFuncitonsDAL.lookup_Funcitons_subtypename(industryname,industrytypename);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtFuncitons;
							}







				}


			}
