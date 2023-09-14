namespace DineandDiscover.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 14:17:42
			public class BasicInformationModel
			{

			 public System.Guid ?BasicInformationid	{ get; set; }
public System.Guid ?tenantid { get; set; }

[xssFilter]
public String restaurantimage{ get; set; }

[xssFilter]
public String nameoftherestaurant{ get; set; }

[xssFilter]
public String restaurantlocation{ get; set; }

[xssFilter]
public String cuisinetype{ get; set; }
public System.Guid ?createduser	{ get; set; }
[DataType(DataType.Date)]
[ModelBinder(BinderType = typeof(DateTimeModelBinder))]
[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
public System.DateTime ?createddate	{ get; set; }
public System.Guid ?modifieduser	{ get; set; }
[DataType(DataType.Date)]
[ModelBinder(BinderType = typeof(DateTimeModelBinder))]
[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
public System.DateTime ?modifieddate	{ get; set; }
public bool isdeleted	{ get; set; }
[xssFilter]
                        [Required(ErrorMessage = "craftmyapp_actionmethodname is required,please pass current action name")]
                        public String craftmyapp_actionmethodname{ get; set; }



			}
			

			public class BasicInformationModelValidator: AbstractValidator<BasicInformationModel>
			{
					 
					public BasicInformationModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Basic_Information", () =>
                                    {
                                        {



}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Basic_Information", () =>
                                    {
                                        {



}

                                    });

						 
						
					}

			}

			

            


 


			}
