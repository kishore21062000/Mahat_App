namespace AIData.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:44:55
			public class SubTypesModel
			{

			 public System.Guid ?SubTypesid	{ get; set; }

public Guid? industryname	{ get; set; }

public Guid? industrytypename	{ get; set; }

[xssFilter]
public String subtypename{ get; set; }

[xssFilter]
public String description{ get; set; }
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
			

			public class SubTypesModelValidator: AbstractValidator<SubTypesModel>
			{
					 
					public SubTypesModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_SubTypes", () =>
                                    {
                                        {



}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_SubTypes", () =>
                                    {
                                        {



}

                                    });

						 
						
					}

			}

			

            


 


			}
