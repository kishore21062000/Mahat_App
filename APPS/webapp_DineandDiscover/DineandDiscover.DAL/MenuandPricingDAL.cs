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
			    //This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:36:11
			    public class MenuandPricingDAL
			    {
					public virtual string db_connectionstring{get;set;}
			 	    public MenuandPricingDAL(string connectionString)
				    {
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_Menu_and_Pricing(MenuandPricingModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_Menu_and_Pricing\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_menuandpricingid",NpgsqlDbType.Uuid,(object)model.MenuandPricingid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_menus",NpgsqlDbType.Uuid,(object)model.menus??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi",NpgsqlDbType.Varchar,(object)model.foodi??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_food",NpgsqlDbType.Varchar,(object)model.food??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc",NpgsqlDbType.Numeric,(object)model.foodc??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi1",NpgsqlDbType.Varchar,(object)model.foodi1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn1",NpgsqlDbType.Varchar,(object)model.foodn1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc1",NpgsqlDbType.Numeric,(object)model.foodc1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi2",NpgsqlDbType.Varchar,(object)model.foodi2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn2",NpgsqlDbType.Varchar,(object)model.foodn2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc2",NpgsqlDbType.Numeric,(object)model.foodc2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi3",NpgsqlDbType.Varchar,(object)model.foodi3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn3",NpgsqlDbType.Varchar,(object)model.foodn3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc3",NpgsqlDbType.Numeric,(object)model.foodc3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi4",NpgsqlDbType.Varchar,(object)model.foodi4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn4",NpgsqlDbType.Varchar,(object)model.foodn4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc4",NpgsqlDbType.Numeric,(object)model.foodc4??DBNull.Value);
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
public virtual System.Data.DataTable getById_MenuandPricing(string MenuandPricingid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_MenuandPricing\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_menuandpricingid",(object)MenuandPricingid??DBNull.Value);
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
			 public virtual string  Update_Menu_and_Pricing(MenuandPricingModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_Menu_and_Pricing\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_menuandpricingid",NpgsqlDbType.Uuid,(object)model.MenuandPricingid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_menus",NpgsqlDbType.Uuid,(object)model.menus??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi",NpgsqlDbType.Varchar,(object)model.foodi??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_food",NpgsqlDbType.Varchar,(object)model.food??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc",NpgsqlDbType.Numeric,(object)model.foodc??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi1",NpgsqlDbType.Varchar,(object)model.foodi1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn1",NpgsqlDbType.Varchar,(object)model.foodn1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc1",NpgsqlDbType.Numeric,(object)model.foodc1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi2",NpgsqlDbType.Varchar,(object)model.foodi2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn2",NpgsqlDbType.Varchar,(object)model.foodn2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc2",NpgsqlDbType.Numeric,(object)model.foodc2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi3",NpgsqlDbType.Varchar,(object)model.foodi3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn3",NpgsqlDbType.Varchar,(object)model.foodn3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc3",NpgsqlDbType.Numeric,(object)model.foodc3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodi4",NpgsqlDbType.Varchar,(object)model.foodi4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodn4",NpgsqlDbType.Varchar,(object)model.foodn4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_foodc4",NpgsqlDbType.Numeric,(object)model.foodc4??DBNull.Value);
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
public virtual string  Remove_Menu_and_Pricing(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_Menu_and_Pricing\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_menuandpricingid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable Menu_and_Pricing_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Menu_and_Pricing_List\"", npsql))
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
			   
			 
public virtual System.Data.DataTable get_all_MenuandPricing(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_MenuandPricing\"", npsql))
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
public virtual System.Data.DataSet getById_sp_all_MenuandPricing(string MenuandPricingid)
			 {
				DataSet dataSet=new DataSet();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_MenuandPricing\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_menuandpricingid",(object)MenuandPricingid??DBNull.Value);
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
			  public virtual string  verify_MenuandPricing(string MenuandPricingid,string verifiedby,string verifiedstatus,string reviewcomments)
			 { 
				 String ResponseMessage="";
					try{
						 
							 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"verify_MenuandPricing\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										 dbCommand.Parameters.AddWithValue("pvar_menuandpricingid",(object)MenuandPricingid??DBNull.Value);
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
public virtual System.Data.DataTable lookup_MenuandPricing_menus(String tenantid)
							        {
                                            DataSet dataSet = new DataSet();
									        DataTable dataTable=new DataTable();
									        try{

                                        		        using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					                                    {
						                                    npsql.Open();
						                                    using (var dbCommand = new NpgsqlCommand("\"lookup_MenuandPricing_menus\"", npsql))
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
