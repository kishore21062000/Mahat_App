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
				//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:50:42
				public class ReviewsandRatingsController : Controller
				{
				public ReviewsandRatingsController(IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				{
					 _configuration = configuration;
					 _logger = loggerFactory.CreateLogger<ReviewsandRatingsController>();
					 _connectionSettings = connectionSettings;
					 objReviewsandRatingsDAL = new ReviewsandRatingsDAL(_connectionSettings.Value.ConnectionString);
                     obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                     objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					 hostingEnv = hostingEnvironment;
				}
				private ReviewsandRatingsDAL objReviewsandRatingsDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;

 

			    
            [HttpPost()]
            [ActionName("Add_Reviews_and_Ratings")]
            public virtual IActionResult Add_Reviews_and_Ratings([FromBody]ReviewsandRatingsModel model)
            { 
              string message = "";
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_Reviews_and_Ratings";
            try{

            if (ModelState.IsValid)
            {

            	ReviewsandRatingsModelValidator validator = new ReviewsandRatingsModelValidator();
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
		     

                                
            		                
                                   message = objReviewsandRatingsDAL.Add_Reviews_and_Ratings(model);
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

            	_logger.LogError("ReviewsandRatingsModel - Add_Reviews_and_Ratings , Validation Error :" + message);
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
			  [ActionName("getById_ReviewsandRatings")]
			  public virtual System.Data.DataTable getById_ReviewsandRatings(string ReviewsandRatingsid,string loginUserID="")
			  { 
				    DataTable dtReviewsandRatings = new DataTable();
					try
					{
						  dtReviewsandRatings = objReviewsandRatingsDAL.getById_ReviewsandRatings(ReviewsandRatingsid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtReviewsandRatings;

			  }
			  [HttpPost()]
			  [ActionName("Update_Reviews_and_Ratings")]
			  public virtual IActionResult Update_Reviews_and_Ratings([FromBody]ReviewsandRatingsModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_Reviews_and_Ratings";

					try{

					if (ModelState.IsValid)
					{

						ReviewsandRatingsModelValidator validator = new ReviewsandRatingsModelValidator();
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

		       
                                	
							    message = objReviewsandRatingsDAL.Update_Reviews_and_Ratings(model);	
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

						_logger.LogError("ReviewsandRatingsModel - Update_Reviews_and_Ratings, Validation Error :" + message);
					
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
            public virtual string Remove_Reviews_and_Ratings(string ReviewsandRatingsid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_Reviews_and_Ratings";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		                      
		       
                        	 message = objReviewsandRatingsDAL.Remove_Reviews_and_Ratings(ReviewsandRatingsid,loginUserID);
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
			
			[ActionName("Reviews_and_Ratings_List")]
			public virtual System.Data.DataTable Reviews_and_Ratings_List(string loginUserID="")
			{
					 
				  	DataTable dtReviewsandRatings = new DataTable();
					try
					{
						dtReviewsandRatings = objReviewsandRatingsDAL.Reviews_and_Ratings_List();
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtReviewsandRatings;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_ReviewsandRatings")]
			public virtual System.Data.DataTable get_all_ReviewsandRatings(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtReviewsandRatings = new DataTable();
					try
					{
						dtReviewsandRatings = objReviewsandRatingsDAL.get_all_ReviewsandRatings(tenantid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dtReviewsandRatings;

			   }
[HttpGet()]
			  [ActionName("getById_sp_all_ReviewsandRatings")]
			  public virtual System.Data.DataSet getById_sp_all_ReviewsandRatings(string ReviewsandRatingsid)
			  { 
				    DataSet dsReviewsandRatings = new DataSet();
					try
					{
						  dsReviewsandRatings = objReviewsandRatingsDAL.getById_sp_all_ReviewsandRatings(ReviewsandRatingsid);
					}
					catch (Exception ex)
					{
						_logger.LogError(ex.Message);
					}
					return dsReviewsandRatings;

			  }
[HttpGet()]
							[ActionName("lookup_ReviewsandRatings_reviewsandratings")]
							public virtual System.Data.DataTable lookup_ReviewsandRatings_reviewsandratings(String tenantid,string loginUserID="")
							{
									DataTable dtReviewsandRatings = new DataTable();
									try
									{
										dtReviewsandRatings = objReviewsandRatingsDAL.lookup_ReviewsandRatings_reviewsandratings(tenantid);
									}
									catch (Exception ex)
									{
										_logger.LogError(ex.Message);
									}
									return dtReviewsandRatings;
							}







				}


			}
