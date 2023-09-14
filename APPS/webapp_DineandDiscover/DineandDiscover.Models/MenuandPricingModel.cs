namespace DineandDiscover.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:36:11
			public class MenuandPricingModel
			{

			 public System.Guid ?MenuandPricingid	{ get; set; }

public Guid? menus	{ get; set; }

[xssFilter]
public String foodi{ get; set; }

[xssFilter]
public String food{ get; set; }

public decimal? foodc{ get; set; }

[xssFilter]
public String foodi1{ get; set; }

[xssFilter]
public String foodn1{ get; set; }

public decimal? foodc1{ get; set; }

[xssFilter]
public String foodi2{ get; set; }

[xssFilter]
public String foodn2{ get; set; }

public decimal? foodc2{ get; set; }

[xssFilter]
public String foodi3{ get; set; }

[xssFilter]
public String foodn3{ get; set; }

public decimal? foodc3{ get; set; }

[xssFilter]
public String foodi4{ get; set; }

[xssFilter]
public String foodn4{ get; set; }

public decimal? foodc4{ get; set; }
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
			

			public class MenuandPricingModelValidator: AbstractValidator<MenuandPricingModel>
			{
					 
					public MenuandPricingModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Menu_and_Pricing", () =>
                                    {
                                        {


RuleFor(m => m.foodc)
.LessThanOrEqualTo(99999999).WithMessage("foodc should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc1)
.LessThanOrEqualTo(99999999).WithMessage("foodc1 should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc2)
.LessThanOrEqualTo(99999999).WithMessage("foodc2 should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc3)
.LessThanOrEqualTo(99999999).WithMessage("foodc3 should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc4)
.LessThanOrEqualTo(99999999).WithMessage("foodc4 should be LessThanOrEqualTo 99999999")

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Menu_and_Pricing", () =>
                                    {
                                        {


RuleFor(m => m.foodc)
.LessThanOrEqualTo(99999999).WithMessage("foodc should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc1)
.LessThanOrEqualTo(99999999).WithMessage("foodc1 should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc2)
.LessThanOrEqualTo(99999999).WithMessage("foodc2 should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc3)
.LessThanOrEqualTo(99999999).WithMessage("foodc3 should be LessThanOrEqualTo 99999999")

;


RuleFor(m => m.foodc4)
.LessThanOrEqualTo(99999999).WithMessage("foodc4 should be LessThanOrEqualTo 99999999")

;
}

                                    });

						 
						
					}

			}

			

            


 


			}
