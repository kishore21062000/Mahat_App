namespace DineandDiscover.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 13:52:10
			public class ReservationandDietaryOptionsModel
			{

			 public System.Guid ?ReservationandDietaryOptionsid	{ get; set; }

public Guid? reservationanddietaryoptions	{ get; set; }

public bool reservationsavailable	{ get; set; }

public bool vegetarian	{ get; set; }

public bool nonvegetarian	{ get; set; }

public bool diaryfree	{ get; set; }

public bool nutfree	{ get; set; }

public bool seafood	{ get; set; }

public bool lowsodium	{ get; set; }
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
			

			public class ReservationandDietaryOptionsModelValidator: AbstractValidator<ReservationandDietaryOptionsModel>
			{
					 
					public ReservationandDietaryOptionsModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Reservation_and_Dietary_Options", () =>
                                    {
                                        {







}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Reservation_and_Dietary_Options", () =>
                                    {
                                        {







}

                                    });

						 
						
					}

			}

			

            


 


			}
