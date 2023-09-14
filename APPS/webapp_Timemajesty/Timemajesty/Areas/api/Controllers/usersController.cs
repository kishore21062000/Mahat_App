namespace TimemajestyWebApi.Controllers
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
				using Timemajesty.Models;
				using Timemajesty.DAL;
				using FluentValidation.Results;

				using Microsoft.AspNetCore.Hosting;
				using System.IO;
				using System.Net.Http.Headers;
				[Authorize()]
				[Area("api")]  [Route("api/[controller]/[action]")]
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/20/2023 16:16:47
				public class usersController : Controller
				{
				public usersController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<usersController>();
					 _connectionSettings = connectionSettings;
					 objusersDAL = new usersDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private usersDAL objusersDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    [HttpGet()]
			  [ActionName("getById_alloweddevices")]
			  public virtual System.Data.DataTable getById_alloweddevices(string usersid)
			  {
					DataTable dtusers_alloweddevices = new DataTable();
					try
					{
						dtusers_alloweddevices = objusersDAL.getById_alloweddevices(usersid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtusers_alloweddevices;


			  }

[AllowAnonymous()]
            [HttpPost()]
            [ActionName("Register_Profile")]
            public virtual IActionResult Register_Profile([FromBody]usersModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Register_Profile";
            try{

            if (ModelState.IsValid)
            {

            	usersModelValidator validator = new usersModelValidator();
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
		     

                                
            		                
                                   message = objusersDAL.Register_Profile(model);
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

            	_logger.LogError("usersModel - Register_Profile , Validation Error :" + message);
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
			  [ActionName("getById_users")]
			  public virtual System.Data.DataTable getById_users(string usersid,string loginUserID="")
			  { 
				    DataTable dtusers = new DataTable();
					try
					{
						  dtusers = objusersDAL.getById_users(usersid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtusers;

			  }
			  [HttpPost()]
			  [ActionName("Update_Profile")]
			  public virtual IActionResult Update_Profile([FromBody]usersModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Profile";

					try{

					if (ModelState.IsValid)
					{

						usersModelValidator validator = new usersModelValidator();
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

		       
                                	
							    message = objusersDAL.Update_Profile(model);	
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

						_logger.LogError("usersModel - Update_Profile, Validation Error :" + message);
					
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
            public virtual string Suspend_Profile(string usersid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Suspend_Profile";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objusersDAL.Suspend_Profile(usersid,loginUserID);
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

            [AllowAnonymous()]
		[HttpPost()]
		[ActionName("get_decryptedPassword")]
		public virtual string get_decryptedPassword([FromBody] userloginModel model)
		{
			string decryptedPassword = objusersDAL.get_decryptedPassword(model.username);

			return decryptedPassword;
		}
			[AllowAnonymous()]
[HttpGet()]
[ActionName("get_roleAuthorizations")]
public virtual System.Data.DataTable get_roleAuthorizations(string viewactionroles)
{
	 
	DataTable dtusers = new DataTable();
	try
	{
		dtusers = objusersDAL.get_roleAuthorizations(viewactionroles);
	}
	catch (Exception ex)
	{
		_logger.LogError(ex.Message);
	}
	return dtusers;

}
[AllowAnonymous()]
[HttpGet()]
[ActionName("get_project_Menu")]
public virtual System.Data.DataTable get_project_Menu(string viewactionroles,string SubSystem)
{
	 
	DataTable dtusers = new DataTable();
	try
	{
		dtusers = objusersDAL.get_project_Menu(viewactionroles,SubSystem);
	}
	catch (Exception ex)
	{
		_logger.LogError(ex.Message);
	}
	return dtusers;

}
			[AllowAnonymous()]
        [HttpGet()]
		[ActionName("get_roles")]
		public virtual System.Data.DataTable get_roles(string roles)
		{
			    DataTable dt= objusersDAL.get_roles(roles);
				return dt;
		}
			
			
			[AllowAnonymous()]
		[HttpPost()]
		[ActionName("checkUserAuthentication_users")]
		public virtual System.Data.DataTable checkUserAuthentication_users([FromBody]userloginModel model)
		{
			    DataTable dt= objusersDAL.checkUserAuthentication_users(model);
				if (dt.Rows.Count > 0)
				{
				dt.Columns.Add("token");
				var claims = new[]
				{
				new Claim(ClaimTypes.Name, model.username)
				};
				var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
				var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
				var token = new JwtSecurityToken(
				issuer: _configuration["ValidIssuer"],
				audience: "yourdomain.com",
				claims: claims,
				expires: DateTime.Now.AddMinutes(3000),
				signingCredentials: creds);
				string token_ = new JwtSecurityTokenHandler().WriteToken(token);
				dt.Rows[0]["token"] = token_;


                         
                        access_logsModel objExternalapilogsModel = new access_logsModel();
                        objExternalapilogsModel.logged_date = DateTime.Now;
                        objExternalapilogsModel.expiry_date = DateTime.Now.AddMinutes(60);
                        objExternalapilogsModel.external_entity_name = "";
                        objExternalapilogsModel.user_token = token_;
                        objExternalapilogsModel.users_id =dt.Rows[0]["usersid"].ToString();
                        objExternalapilogsModel.latlan = "";
                        objExternalapilogsModel.clientipaddress = "";
                        objExternalapilogsModel.devicename = "";
                        objExternalapilogsModel.browsername = "";
                        objExternalapilogsModel.external_users_id = "";
                        objExternalapilogsModel.createduser = new Guid(dt.Rows[0]["usersid"].ToString());
                        obj_External_System_DAL.Create_access_logs(objExternalapilogsModel);

                        ExternalSystemUtility objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
				        objExternalSystemUtitlity.Insert_external_tokens(dt.Rows[0]["usersid"].ToString(),model);

                }
				return dt
				;
		}
[HttpGet()]
			
			[ActionName("List_of_User_Profiles")]
			public virtual System.Data.DataTable List_of_User_Profiles(string tenantid
,string loginUserID="")
			{
					 
				  	DataTable dtusers = new DataTable();
					try
					{
						dtusers = objusersDAL.List_of_User_Profiles( tenantid
);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtusers;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_users")]
			public virtual System.Data.DataTable get_all_users(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtusers = new DataTable();
					try
					{
						dtusers = objusersDAL.get_all_users(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtusers;

			   }
 
			  [HttpPost()]
			  [ActionName("ChangePassword")]
			  public virtual string ChangePassword([FromBody]usersChangePasswordModel model)
			  { 
				  string message = "";
					try{
						
						  message = objusersDAL.ChangePassword(model);	
						 

					}catch(Exception ex){
						message=ex.Message;
						_logger.LogError(ex.Message);
					}
					
					return message;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_users")]
			  public virtual System.Data.DataSet getById_sp_all_users(string usersid)
			  { 
				    DataSet dsusers = new DataSet();
					try
					{
						  dsusers = objusersDAL.getById_sp_all_users(usersid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsusers;

			  }







				}


			}
