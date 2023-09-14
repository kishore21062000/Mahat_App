namespace DineandDiscover.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 14:54:50
			public class SpecialEventandServicesModel
			{

			 public System.Guid ?SpecialEventandServicesid	{ get; set; }

public Guid? specialeventandservices	{ get; set; }

[xssFilter]
public String devent1{ get; set; }

[xssFilter]
public String devent2{ get; set; }

[xssFilter]
public String devent3{ get; set; }

[xssFilter]
public String uevent1{ get; set; }

[xssFilter]
public String uevent2{ get; set; }

[xssFilter]
public String uevent3{ get; set; }

[xssFilter]
public String sevent1{ get; set; }

[xssFilter]
public String sevent2{ get; set; }

[xssFilter]
public String sevent3{ get; set; }

[xssFilter]
public String sevent4{ get; set; }

[xssFilter]
public String sevent5{ get; set; }

[xssFilter]
public String deliveryconditionasperchargeindication{ get; set; }

public bool deliveryavailable	{ get; set; }

[xssFilter]
public String paymenturl{ get; set; }

[xssFilter]
public String paymentqrcode{ get; set; }

[xssFilter]
public String paymentmobilenumber{ get; set; }

public bool payoffline	{ get; set; }
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
			

			public class SpecialEventandServicesModelValidator: AbstractValidator<SpecialEventandServicesModel>
			{
					 
					public SpecialEventandServicesModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Special_Event_and_Services", () =>
                                    {
                                        {















RuleFor(m => m.paymentmobilenumber)
.MaximumLength(20).WithMessage("The allowed length of Payment Mobile Number :  is 20 characters or fewer ")

;

}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Special_Event_and_Services", () =>
                                    {
                                        {















RuleFor(m => m.paymentmobilenumber)
.MaximumLength(20).WithMessage("The allowed length of Payment Mobile Number :  is 20 characters or fewer ")

;

}

                                    });

						 
						
					}

			}

			

            


 


			}
