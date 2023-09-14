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
			    //This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/17/2023 11:18:01
			    public class spclfeaturesavailDAL
			    {
					public virtual string db_connectionstring{get;set;}
			 	    public spclfeaturesavailDAL(string connectionString)
				    {
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_specialfeatures_avail(spclfeaturesavailModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_specialfeatures_avail\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_spclfeaturesavailid",NpgsqlDbType.Uuid,(object)model.spclfeaturesavailid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_spclfeatures",NpgsqlDbType.Uuid,(object)model.spclfeatures??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofbalcony",NpgsqlDbType.Varchar,(object)model.imageofbalcony??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofkidsplayarea",NpgsqlDbType.Varchar,(object)model.imageofkidsplayarea??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofcocktail",NpgsqlDbType.Varchar,(object)model.imageofcocktail??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_openingtime",NpgsqlDbType.Varchar,(object)model.openingtime??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_closingtime",NpgsqlDbType.Varchar,(object)model.closingtime??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_contactinfo",NpgsqlDbType.Varchar,(object)model.contactinfo??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_contactmail",NpgsqlDbType.Varchar,(object)model.contactmail??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_specialfeaturefordisability",NpgsqlDbType.Boolean,(object)model.specialfeaturefordisability??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_walkingstickavailable",NpgsqlDbType.Boolean,(object)model.walkingstickavailable??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_wheelchairavailability",NpgsqlDbType.Boolean,(object)model.wheelchairavailability??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofentrance",NpgsqlDbType.Varchar,(object)model.imageofentrance??DBNull.Value);
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
public virtual System.Data.DataTable getById_spclfeaturesavail(string spclfeaturesavailid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_spclfeaturesavail\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_spclfeaturesavailid",(object)spclfeaturesavailid??DBNull.Value);
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
			 public virtual string  Update_specialfeatures_avail(spclfeaturesavailModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_specialfeatures_avail\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_spclfeaturesavailid",NpgsqlDbType.Uuid,(object)model.spclfeaturesavailid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_spclfeatures",NpgsqlDbType.Uuid,(object)model.spclfeatures??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofbalcony",NpgsqlDbType.Varchar,(object)model.imageofbalcony??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofkidsplayarea",NpgsqlDbType.Varchar,(object)model.imageofkidsplayarea??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofcocktail",NpgsqlDbType.Varchar,(object)model.imageofcocktail??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_openingtime",NpgsqlDbType.Varchar,(object)model.openingtime??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_closingtime",NpgsqlDbType.Varchar,(object)model.closingtime??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_contactinfo",NpgsqlDbType.Varchar,(object)model.contactinfo??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_contactmail",NpgsqlDbType.Varchar,(object)model.contactmail??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_specialfeaturefordisability",NpgsqlDbType.Boolean,(object)model.specialfeaturefordisability??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_walkingstickavailable",NpgsqlDbType.Boolean,(object)model.walkingstickavailable??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_wheelchairavailability",NpgsqlDbType.Boolean,(object)model.wheelchairavailability??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_imageofentrance",NpgsqlDbType.Varchar,(object)model.imageofentrance??DBNull.Value);
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
public virtual string  Remove_specialfeatures_avail(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_specialfeatures_avail\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_spclfeaturesavailid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable specialfeatures_avail_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"specialfeatures_avail_List\"", npsql))
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
			   
			 
public virtual System.Data.DataTable get_all_spclfeaturesavail(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_spclfeaturesavail\"", npsql))
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
public virtual System.Data.DataSet getById_sp_all_spclfeaturesavail(string spclfeaturesavailid)
			 {
				DataSet dataSet=new DataSet();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_spclfeaturesavail\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_spclfeaturesavailid",(object)spclfeaturesavailid??DBNull.Value);
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
			  public virtual string  verify_spclfeaturesavail(string spclfeaturesavailid,string verifiedby,string verifiedstatus,string reviewcomments)
			 { 
				 String ResponseMessage="";
					try{
						 
							 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"verify_spclfeaturesavail\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										 dbCommand.Parameters.AddWithValue("pvar_spclfeaturesavailid",(object)spclfeaturesavailid??DBNull.Value);
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
public virtual System.Data.DataTable lookup_spclfeaturesavail_spclfeatures(String tenantid)
							        {
                                            DataSet dataSet = new DataSet();
									        DataTable dataTable=new DataTable();
									        try{

                                        		        using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					                                    {
						                                    npsql.Open();
						                                    using (var dbCommand = new NpgsqlCommand("\"lookup_spclfeaturesavail_spclfeatures\"", npsql))
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
