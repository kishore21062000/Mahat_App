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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 14:04:14
				public class FacilitiesandAmenitiesController : Controller
				{
				public FacilitiesandAmenitiesController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<FacilitiesandAmenitiesController>();
					 _connectionSettings = connectionSettings;
					 objFacilitiesandAmenitiesDAL = new FacilitiesandAmenitiesDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private FacilitiesandAmenitiesDAL objFacilitiesandAmenitiesDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_Facilities_and_Amenities")]
            public virtual IActionResult Add_Facilities_and_Amenities([FromBody]FacilitiesandAmenitiesModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_Facilities_and_Amenities";
            try{

            if (ModelState.IsValid)
            {

            	FacilitiesandAmenitiesModelValidator validator = new FacilitiesandAmenitiesModelValidator();
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
		     

                                
            		                
                                   message = objFacilitiesandAmenitiesDAL.Add_Facilities_and_Amenities(model);
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

            	_logger.LogError("FacilitiesandAmenitiesModel - Add_Facilities_and_Amenities , Validation Error :" + message);
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
			  [ActionName("getById_FacilitiesandAmenities")]
			  public virtual System.Data.DataTable getById_FacilitiesandAmenities(string FacilitiesandAmenitiesid,string loginUserID="")
			  { 
				    DataTable dtFacilitiesandAmenities = new DataTable();
					try
					{
						  dtFacilitiesandAmenities = objFacilitiesandAmenitiesDAL.getById_FacilitiesandAmenities(FacilitiesandAmenitiesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtFacilitiesandAmenities;

			  }
			  [HttpPost()]
			  [ActionName("Update_Facilities_and_Amenities")]
			  public virtual IActionResult Update_Facilities_and_Amenities([FromBody]FacilitiesandAmenitiesModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Facilities_and_Amenities";

					try{

					if (ModelState.IsValid)
					{

						FacilitiesandAmenitiesModelValidator validator = new FacilitiesandAmenitiesModelValidator();
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

		       
                                	
							    message = objFacilitiesandAmenitiesDAL.Update_Facilities_and_Amenities(model);	
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

						_logger.LogError("FacilitiesandAmenitiesModel - Update_Facilities_and_Amenities, Validation Error :" + message);
					
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
            public virtual string Remove_Facilities_and_Amenities(string FacilitiesandAmenitiesid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_Facilities_and_Amenities";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objFacilitiesandAmenitiesDAL.Remove_Facilities_and_Amenities(FacilitiesandAmenitiesid,loginUserID);
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
			
			[ActionName("Facilities_and_Amenities_List")]
			public virtual System.Data.DataTable Facilities_and_Amenities_List(string loginUserID="")
			{
					 
				  	DataTable dtFacilitiesandAmenities = new DataTable();
					try
					{
						dtFacilitiesandAmenities = objFacilitiesandAmenitiesDAL.Facilities_and_Amenities_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtFacilitiesandAmenities;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_FacilitiesandAmenities")]
			public virtual System.Data.DataTable get_all_FacilitiesandAmenities(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtFacilitiesandAmenities = new DataTable();
					try
					{
						dtFacilitiesandAmenities = objFacilitiesandAmenitiesDAL.get_all_FacilitiesandAmenities(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtFacilitiesandAmenities;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_FacilitiesandAmenities")]
			  public virtual System.Data.DataSet getById_sp_all_FacilitiesandAmenities(string FacilitiesandAmenitiesid)
			  { 
				    DataSet dsFacilitiesandAmenities = new DataSet();
					try
					{
						  dsFacilitiesandAmenities = objFacilitiesandAmenitiesDAL.getById_sp_all_FacilitiesandAmenities(FacilitiesandAmenitiesid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsFacilitiesandAmenities;

			  }
[HttpGet()]
							[ActionName("lookup_FacilitiesandAmenities_facilitiesandamenities")]
							public virtual System.Data.DataTable lookup_FacilitiesandAmenities_facilitiesandamenities(String tenantid,string loginUserID="")
							{
									DataTable dtFacilitiesandAmenities = new DataTable();
									try
									{
										dtFacilitiesandAmenities = objFacilitiesandAmenitiesDAL.lookup_FacilitiesandAmenities_facilitiesandamenities(tenantid);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtFacilitiesandAmenities;
							}







				}


			}
