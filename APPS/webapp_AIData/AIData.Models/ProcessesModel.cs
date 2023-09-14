namespace AIData.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:54:52
			public class ProcessesModel
			{

			 public System.Guid ?Processesid	{ get; set; }

public Guid? industryname	{ get; set; }

public Guid? industrytypename	{ get; set; }

public Guid? subtypename	{ get; set; }

public Guid? businessfunctionname	{ get; set; }

[xssFilter]
public String businessprocessname{ get; set; }

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
			

			public class ProcessesModelValidator: AbstractValidator<ProcessesModel>
			{
					 
					public ProcessesModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Processes", () =>
                                    {
                                        {





}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Processes", () =>
                                    {
                                        {





}

                                    });

						 
						
					}

			}

			

            


 


			}
