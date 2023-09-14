namespace Timemajesty.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/25/2023 09:04:38
			public class watchlistModel
			{

			 public System.Guid ?watchlistid	{ get; set; }
public System.Guid ?tenantid { get; set; }

[xssFilter]
public String productname{ get; set; }

[xssFilter]
public String productid{ get; set; }


[xssFilter]
public String productdescription { get; set; }

public bool availability	{ get; set; }

[xssFilter]
public String rating{ get; set; }

public decimal? price{ get; set; }
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
			

			public class watchlistModelValidator: AbstractValidator<watchlistModel>
			{
					 
					public watchlistModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_watchlist", () =>
                                    {
                                        {RuleFor(m => m.productname)
.NotEmpty().WithMessage("productname is required")
.MaximumLength(128).WithMessage("The allowed length of productname is 128 characters or fewer")
;
RuleFor(m => m.productid)
.NotEmpty().WithMessage("productid is required")
.MaximumLength(128).WithMessage("The allowed length of productid is 128 characters or fewer")
;
											RuleFor(m => m.productdescription)
											.NotEmpty().WithMessage("productdescription is required")
											.MaximumLength(1024).WithMessage("The allowed length of productid is 1024 characters or fewer")
											;


RuleFor(m => m.price)
.LessThanOrEqualTo(99999999).WithMessage("Price should be LessThanOrEqualTo 99999999")

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_watchlist", () =>
                                    {
                                        {RuleFor(m => m.productname)
.NotEmpty().WithMessage("productname is required")
.MaximumLength(128).WithMessage("The allowed length of productname is 128 characters or fewer")
;
RuleFor(m => m.productid)
.NotEmpty().WithMessage("productid is required")
.MaximumLength(128).WithMessage("The allowed length of productid is 128 characters or fewer")
;

											RuleFor(m => m.productdescription)
											.NotEmpty().WithMessage("productdescription is required")
											.MaximumLength(1024).WithMessage("The allowed length of productdescription is 1024 characters or fewer")
											;

											RuleFor(m => m.price)
.LessThanOrEqualTo(99999999).WithMessage("Price should be LessThanOrEqualTo 99999999")

;
}

                                    });

						 
						
					}

			}

			

            


 


			}
