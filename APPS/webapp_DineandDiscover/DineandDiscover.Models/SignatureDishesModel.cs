namespace DineandDiscover.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 13:58:29
			public class SignatureDishesModel
			{

			 public System.Guid ?SignatureDishesid	{ get; set; }

public Guid? signaturedishes	{ get; set; }

[xssFilter]
public String dishimage1{ get; set; }

[xssFilter]
public String dishname1{ get; set; }

[xssFilter]
public String dishimage2{ get; set; }

[xssFilter]
public String dishname2{ get; set; }
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
			

			public class SignatureDishesModelValidator: AbstractValidator<SignatureDishesModel>
			{
					 
					public SignatureDishesModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Signature_Dishes", () =>
                                    {
                                        {




}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Signature_Dishes", () =>
                                    {
                                        {




}

                                    });

						 
						
					}

			}

			

            


 


			}
