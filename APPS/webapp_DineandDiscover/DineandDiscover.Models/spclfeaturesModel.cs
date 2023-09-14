namespace DineandDiscover.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/17/2023 09:37:05
			public class spclfeaturesModel
			{

			 public System.Guid ?spclfeaturesid	{ get; set; }

public Guid? spclfeatures	{ get; set; }

[xssFilter]
public String videoofbalcony{ get; set; }

[xssFilter]
public String imageofbalcony{ get; set; }

[xssFilter]
public String imageofkidsplayarea{ get; set; }

[xssFilter]
public String videoofkidsplayarea{ get; set; }

[xssFilter]
public String imageofcocktail{ get; set; }

[xssFilter]
public String videoofcocktail{ get; set; }

[xssFilter]
public String openingtime{ get; set; }

[xssFilter]
public String closingtime{ get; set; }

[xssFilter]
public String contactinfo{ get; set; }

[xssFilter]
public String contactmail{ get; set; }

public bool specialfeaturefordisability	{ get; set; }

public bool walkingstickavailable	{ get; set; }

public bool wheelchairavailability	{ get; set; }

[xssFilter]
public String imageofentrance{ get; set; }

[xssFilter]
public String videoofoverallrestaurant{ get; set; }
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
			

			public class spclfeaturesModelValidator: AbstractValidator<spclfeaturesModel>
			{
					 
					public spclfeaturesModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_specialfeatures_avail", () =>
                                    {
                                        {








RuleFor(m => m.contactinfo)
.MaximumLength(20).WithMessage("The allowed length of Contact Info is 20 characters or fewer ")

;
RuleFor(m => m.contactmail)
.MaximumLength(128).WithMessage("The allowed length of Contact Mail is 128 characters or fewer")
.EmailAddress()

;





}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_specialfeatures_avail", () =>
                                    {
                                        {








RuleFor(m => m.contactinfo)
.MaximumLength(20).WithMessage("The allowed length of Contact Info is 20 characters or fewer ")

;
RuleFor(m => m.contactmail)
.MaximumLength(128).WithMessage("The allowed length of Contact Mail is 128 characters or fewer")
.EmailAddress()

;





}

                                    });

						 
						
					}

			}

			

            


 


			}
