namespace DineandDiscover.DAL{
			    using System;
			    using System.Text;
			    using System.Data;
			    using System.Data.Common;
			    using DineandDiscover.Models;
			    using EncrypDecrypt;
			    using Newtonsoft.Json;
                using Npgsql;
				using NpgsqlTypes;
			    //This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 13:52:10
			    public class ReservationandDietaryOptionsDAL
			    {
					public virtual string db_connectionstring{get;set;}
			 	    public ReservationandDietaryOptionsDAL(string connectionString)
				    {
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_Reservation_and_Dietary_Options(ReservationandDietaryOptionsModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_Reservation_and_Dietary_Options\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptionsid",NpgsqlDbType.Uuid,(object)model.ReservationandDietaryOptionsid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptions",NpgsqlDbType.Uuid,(object)model.reservationanddietaryoptions??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_reservationsavailable",NpgsqlDbType.Boolean,(object)model.reservationsavailable??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_vegetarian",NpgsqlDbType.Boolean,(object)model.vegetarian??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_nonvegetarian",NpgsqlDbType.Boolean,(object)model.nonvegetarian??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_diaryfree",NpgsqlDbType.Boolean,(object)model.diaryfree??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_nutfree",NpgsqlDbType.Boolean,(object)model.nutfree??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_seafood",NpgsqlDbType.Boolean,(object)model.seafood??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_lowsodium",NpgsqlDbType.Boolean,(object)model.lowsodium??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_createduser",NpgsqlDbType.Uuid,(object)model.createduser??DBNull.Value);	
                                        NpgsqlParameter outParm = new NpgsqlParameter("pvar_returnMessage", NpgsqlDbType.Varchar)
                                        {
                                             Direction = ParameterDirection.Output
                                        };
                                        dbCommand.Parameters.Add(outParm);;

                                        dbCommand.ExecuteNonQuery();
								        ResponseMessage = outParm.Value.ToString();
								        if (dbCommand.Connection.State != ConnectionState.Closed)
                    			        {
										         dbCommand.Connection.Dispose();
								        }

						        }
						        npsql.Close();
					        }
 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
						Console.WriteLine(ex);
					} 
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable getById_ReservationandDietaryOptions(string ReservationandDietaryOptionsid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_ReservationandDietaryOptions\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptionsid",(object)ReservationandDietaryOptionsid??DBNull.Value);
														using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
														{
															dataSet.Reset();
															dataAdapter.Fill(dataSet);
															dataTable = dataSet.Tables[0];
															if (dbCommand.Connection.State != ConnectionState.Closed)
															{
																dbCommand.Connection.Dispose();
															}
														}
													}
													npsql.Close();
												}
					 
										}catch{
												throw;
										}
										return dataTable;
									 }
			 public virtual string  Update_Reservation_and_Dietary_Options(ReservationandDietaryOptionsModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_Reservation_and_Dietary_Options\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptionsid",NpgsqlDbType.Uuid,(object)model.ReservationandDietaryOptionsid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptions",NpgsqlDbType.Uuid,(object)model.reservationanddietaryoptions??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_reservationsavailable",NpgsqlDbType.Boolean,(object)model.reservationsavailable??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_vegetarian",NpgsqlDbType.Boolean,(object)model.vegetarian??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_nonvegetarian",NpgsqlDbType.Boolean,(object)model.nonvegetarian??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_diaryfree",NpgsqlDbType.Boolean,(object)model.diaryfree??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_nutfree",NpgsqlDbType.Boolean,(object)model.nutfree??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_seafood",NpgsqlDbType.Boolean,(object)model.seafood??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_lowsodium",NpgsqlDbType.Boolean,(object)model.lowsodium??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_modifieduser",NpgsqlDbType.Uuid,model.modifieduser);	
										NpgsqlParameter outParm = new NpgsqlParameter("@returnMessage", NpgsqlDbType.Varchar)
										{
											 Direction = ParameterDirection.Output
										};
										dbCommand.Parameters.Add(outParm);;

										dbCommand.ExecuteNonQuery();
										ResponseMessage = outParm.Value.ToString();
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
												 dbCommand.Connection.Dispose();
										}

								}
								npsql.Close();
							}		 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual string  Remove_Reservation_and_Dietary_Options(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_Reservation_and_Dietary_Options\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptionsid",(object)id??DBNull.Value);
										dbCommand.Parameters.AddWithValue("pvar_modifieduser",(object)loginUserID??DBNull.Value);
										NpgsqlParameter outParm = new NpgsqlParameter("@returnMessage", NpgsqlDbType.Varchar)
										{
											 Direction = ParameterDirection.Output
										};
										dbCommand.Parameters.Add(outParm);;

										dbCommand.ExecuteNonQuery();
										ResponseMessage = outParm.Value.ToString();
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
												 dbCommand.Connection.Dispose();
										}

								}
								npsql.Close();
							}	 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable Reservation_and_Dietary_Options_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Reservation_and_Dietary_Options_List\"", npsql))
								{
									dbCommand.CommandType = CommandType.StoredProcedure;
									
									using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
									{
										dataSet.Reset();
										dataAdapter.Fill(dataSet);
										dataTable = dataSet.Tables[0];
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
											dbCommand.Connection.Dispose();
										}
									}
								}
								npsql.Close();
							}

						 

					}catch{
						throw;
					}


					return dataTable;	


					 

			   }
			   
			 
public virtual System.Data.DataTable get_all_ReservationandDietaryOptions(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_ReservationandDietaryOptions\"", npsql))
								{
									dbCommand.CommandType = CommandType.StoredProcedure;
									dbCommand.Parameters.AddWithValue("pvar_tenantid",(object)tenantid??DBNull.Value);
									using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
									{
										dataSet.Reset();
										dataAdapter.Fill(dataSet);
										dataTable = dataSet.Tables[0];
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
											dbCommand.Connection.Dispose();
										}
									}
								}
								npsql.Close();
							}
						

					}catch{
						throw;
					}
					return dataTable;	


					 

			   }
public virtual System.Data.DataSet getById_sp_all_ReservationandDietaryOptions(string ReservationandDietaryOptionsid)
			 {
				DataSet dataSet=new DataSet();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_ReservationandDietaryOptions\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptionsid",(object)ReservationandDietaryOptionsid??DBNull.Value);
								using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
								{
									dataSet.Reset();
									dataAdapter.Fill(dataSet);
									if (dbCommand.Connection.State != ConnectionState.Closed)
									{
										dbCommand.Connection.Dispose();
									}
								}
							}
							npsql.Close();
						}
					 
				}catch{
						throw;
				}
				return dataSet;
			 }
			  public virtual string  verify_ReservationandDietaryOptions(string ReservationandDietaryOptionsid,string verifiedby,string verifiedstatus,string reviewcomments)
			 { 
				 String ResponseMessage="";
					try{
						 
							 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"verify_ReservationandDietaryOptions\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										 dbCommand.Parameters.AddWithValue("pvar_reservationanddietaryoptionsid",(object)ReservationandDietaryOptionsid??DBNull.Value);
										dbCommand.Parameters.AddWithValue("pvar_verifiedby",(object)verifiedby??DBNull.Value);
										dbCommand.Parameters.AddWithValue("pvar_verifiedstatus",(object)verifiedstatus??DBNull.Value);
										dbCommand.Parameters.AddWithValue("pvar_reviewcomments",(object)reviewcomments??DBNull.Value); 
										NpgsqlParameter outParm = new NpgsqlParameter("@returnMessage", NpgsqlDbType.Varchar)
										{
											 Direction = ParameterDirection.Output
										};
										dbCommand.Parameters.Add(outParm);;

										dbCommand.ExecuteNonQuery();
										ResponseMessage = outParm.Value.ToString();
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
												 dbCommand.Connection.Dispose();
										}

								}
								npsql.Close();
							}
						 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable lookup_ReservationandDietaryOptions_reservationanddietaryoptions(String tenantid)
							        {
                                            DataSet dataSet = new DataSet();
									        DataTable dataTable=new DataTable();
									        try{

                                        		        using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					                                    {
						                                    npsql.Open();
						                                    using (var dbCommand = new NpgsqlCommand("\"lookup_ReservationandDietaryOptions_reservationanddietaryoptions\"", npsql))
						                                    {
                                            
                                                                dbCommand.Parameters.AddWithValue("pvar_tenantid",(object)tenantid??DBNull.Value);                                                    
                                                                dbCommand.CommandType = CommandType.StoredProcedure;
							                                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
                                                                {
                                                                    dataSet.Reset();
                                                                    dataAdapter.Fill(dataSet);
                                                                    dataTable = dataSet.Tables[0];
                                                                    if (dbCommand.Connection.State != ConnectionState.Closed)
												                    {
													                    dbCommand.Connection.Dispose();
												                    }
                                                                }
						                                    }
						                                    npsql.Close();
					                                    }
			 

										 
									        }catch{
										        throw;
									        }
									        return dataTable;
							        }








			    }


			    }
