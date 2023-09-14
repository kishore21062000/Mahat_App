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
			    //This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 14:54:50
			    public class SpecialEventandServicesDAL
			    {
					public virtual string db_connectionstring{get;set;}
			 	    public SpecialEventandServicesDAL(string connectionString)
				    {
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_Special_Event_and_Services(SpecialEventandServicesModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_Special_Event_and_Services\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_specialeventandservicesid",NpgsqlDbType.Uuid,(object)model.SpecialEventandServicesid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_specialeventandservices",NpgsqlDbType.Uuid,(object)model.specialeventandservices??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_devent1",NpgsqlDbType.Varchar,(object)model.devent1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_devent2",NpgsqlDbType.Varchar,(object)model.devent2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_devent3",NpgsqlDbType.Varchar,(object)model.devent3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_uevent1",NpgsqlDbType.Varchar,(object)model.uevent1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_uevent2",NpgsqlDbType.Varchar,(object)model.uevent2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_uevent3",NpgsqlDbType.Varchar,(object)model.uevent3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent1",NpgsqlDbType.Varchar,(object)model.sevent1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent2",NpgsqlDbType.Varchar,(object)model.sevent2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent3",NpgsqlDbType.Varchar,(object)model.sevent3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent4",NpgsqlDbType.Varchar,(object)model.sevent4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent5",NpgsqlDbType.Varchar,(object)model.sevent5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_deliveryconditionasperchargeindication",NpgsqlDbType.Varchar,(object)model.deliveryconditionasperchargeindication??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_deliveryavailable",NpgsqlDbType.Boolean,(object)model.deliveryavailable??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_paymenturl",NpgsqlDbType.Varchar,(object)model.paymenturl??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_paymentqrcode",NpgsqlDbType.Varchar,(object)model.paymentqrcode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_paymentmobilenumber",NpgsqlDbType.Varchar,(object)model.paymentmobilenumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_payoffline",NpgsqlDbType.Boolean,(object)model.payoffline??DBNull.Value);
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
public virtual System.Data.DataTable getById_SpecialEventandServices(string SpecialEventandServicesid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_SpecialEventandServices\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_specialeventandservicesid",(object)SpecialEventandServicesid??DBNull.Value);
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
			 public virtual string  Update_Special_Event_and_Services(SpecialEventandServicesModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_Special_Event_and_Services\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_specialeventandservicesid",NpgsqlDbType.Uuid,(object)model.SpecialEventandServicesid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_specialeventandservices",NpgsqlDbType.Uuid,(object)model.specialeventandservices??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_devent1",NpgsqlDbType.Varchar,(object)model.devent1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_devent2",NpgsqlDbType.Varchar,(object)model.devent2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_devent3",NpgsqlDbType.Varchar,(object)model.devent3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_uevent1",NpgsqlDbType.Varchar,(object)model.uevent1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_uevent2",NpgsqlDbType.Varchar,(object)model.uevent2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_uevent3",NpgsqlDbType.Varchar,(object)model.uevent3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent1",NpgsqlDbType.Varchar,(object)model.sevent1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent2",NpgsqlDbType.Varchar,(object)model.sevent2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent3",NpgsqlDbType.Varchar,(object)model.sevent3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent4",NpgsqlDbType.Varchar,(object)model.sevent4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sevent5",NpgsqlDbType.Varchar,(object)model.sevent5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_deliveryconditionasperchargeindication",NpgsqlDbType.Varchar,(object)model.deliveryconditionasperchargeindication??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_deliveryavailable",NpgsqlDbType.Boolean,(object)model.deliveryavailable??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_paymenturl",NpgsqlDbType.Varchar,(object)model.paymenturl??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_paymentqrcode",NpgsqlDbType.Varchar,(object)model.paymentqrcode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_paymentmobilenumber",NpgsqlDbType.Varchar,(object)model.paymentmobilenumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_payoffline",NpgsqlDbType.Boolean,(object)model.payoffline??DBNull.Value);
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
public virtual string  Remove_Special_Event_and_Services(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_Special_Event_and_Services\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_specialeventandservicesid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable Special_Event_and_Services_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Special_Event_and_Services_List\"", npsql))
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
			   
			 
public virtual System.Data.DataTable get_all_SpecialEventandServices(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_SpecialEventandServices\"", npsql))
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
public virtual System.Data.DataSet getById_sp_all_SpecialEventandServices(string SpecialEventandServicesid)
			 {
				DataSet dataSet=new DataSet();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_SpecialEventandServices\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_specialeventandservicesid",(object)SpecialEventandServicesid??DBNull.Value);
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
			  public virtual string  verify_SpecialEventandServices(string SpecialEventandServicesid,string verifiedby,string verifiedstatus,string reviewcomments)
			 { 
				 String ResponseMessage="";
					try{
						 
							 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"verify_SpecialEventandServices\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										 dbCommand.Parameters.AddWithValue("pvar_specialeventandservicesid",(object)SpecialEventandServicesid??DBNull.Value);
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
public virtual System.Data.DataTable lookup_SpecialEventandServices_specialeventandservices(String tenantid)
							        {
                                            DataSet dataSet = new DataSet();
									        DataTable dataTable=new DataTable();
									        try{

                                        		        using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					                                    {
						                                    npsql.Open();
						                                    using (var dbCommand = new NpgsqlCommand("\"lookup_SpecialEventandServices_specialeventandservices\"", npsql))
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
