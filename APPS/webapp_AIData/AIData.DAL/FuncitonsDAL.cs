namespace AIData.DAL{
			using System;
			using System.Text;
			using System.Data;
			using System.Data.Common;
			using Microsoft.Practices.EnterpriseLibrary.Data;
			using AIData.Models;
			using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
			using EncrypDecrypt;
			using Newtonsoft.Json;
			//This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:47:17
			public class FuncitonsDAL
			{
				 public virtual string db_connectionstring{get;set;}
				public FuncitonsDAL(string connectionString)
				{
					db_connectionstring=connectionString;
				}
				  

			    public virtual string Add_Funcitons(FuncitonsModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							Database db = new SqlDatabase(db_connectionstring);
					
							using(DbCommand dbCommand = db.GetStoredProcCommand("Add_Funcitons"))
							{
								
													db.AddInParameter(dbCommand,"@Funcitonsid",DbType.Guid,model.Funcitonsid);

db.AddInParameter(dbCommand,"@industryname",DbType.Guid,model.industryname);

db.AddInParameter(dbCommand,"@industrytypename",DbType.Guid,model.industrytypename);

db.AddInParameter(dbCommand,"@subtypename",DbType.Guid,model.subtypename);

db.AddInParameter(dbCommand,"@businessfunctionname",DbType.String,model.businessfunctionname);

db.AddInParameter(dbCommand,"@description",DbType.String,model.description);
db.AddInParameter(dbCommand,"@createduser",DbType.Guid,model.createduser);	
								db.AddOutParameter(dbCommand,"@returnMessage",DbType.String,4000);
								db.ExecuteNonQuery(dbCommand);
								ResponseMessage = db.GetParameterValue(dbCommand, "@returnMessage").ToString();
								if (dbCommand.Connection.State != ConnectionState.Closed)
                    			{
										 dbCommand.Connection.Dispose();
								}

							}
						

					}catch(Exception ex){
						ResponseMessage=ex.Message;
						Console.WriteLine(ex);
					} 
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable getById_Funcitons(string Funcitonsid)
					 {
						DataTable dsDataTable=new DataTable();
						try{
								Database db = new SqlDatabase(db_connectionstring);
					 
								using(DbCommand dbCommand = db.GetStoredProcCommand("getById_sp_Funcitons"))
								{

									db.AddInParameter(dbCommand,"@Funcitonsid",DbType.String,Funcitonsid);
									dsDataTable = db.ExecuteDataSet(dbCommand).Tables[0];
											if (dbCommand.Connection.State != ConnectionState.Closed)
                    						{
												 dbCommand.Connection.Dispose();
											}

								}
					 
						}catch{
								throw;
						}
						return dsDataTable;
					 }
			 public virtual string  Update_Funcitons(FuncitonsModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	Database db = new SqlDatabase(db_connectionstring);
						
							using(DbCommand dbCommand = db.GetStoredProcCommand("Update_Funcitons"))
							{
													db.AddInParameter(dbCommand,"@Funcitonsid",DbType.Guid,model.Funcitonsid);

db.AddInParameter(dbCommand,"@industryname",DbType.Guid,model.industryname);

db.AddInParameter(dbCommand,"@industrytypename",DbType.Guid,model.industrytypename);

db.AddInParameter(dbCommand,"@subtypename",DbType.Guid,model.subtypename);

db.AddInParameter(dbCommand,"@businessfunctionname",DbType.String,model.businessfunctionname);

db.AddInParameter(dbCommand,"@description",DbType.String,model.description);
db.AddInParameter(dbCommand,"@modifieduser",DbType.Guid,model.modifieduser);	
								db.AddOutParameter(dbCommand,"@returnMessage",DbType.String,4000);
								db.ExecuteNonQuery(dbCommand);
								ResponseMessage = db.GetParameterValue(dbCommand, "@returnMessage").ToString();

									if (dbCommand.Connection.State != ConnectionState.Closed)
                    				{
										 dbCommand.Connection.Dispose();
									}
							}
						 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual string  Remove_Funcitons(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{
							 Database db = new SqlDatabase(db_connectionstring);
							 	
								using(DbCommand dbCommand = db.GetStoredProcCommand("Remove_Funcitons"))
								{

										db.AddInParameter(dbCommand,"@Funcitonsid",DbType.String,id);
										db.AddInParameter(dbCommand,"@modifieduser",DbType.String,loginUserID);
										db.AddOutParameter(dbCommand,"@returnMessage",DbType.String,4000);
										db.ExecuteNonQuery(dbCommand);
										ResponseMessage = db.GetParameterValue(dbCommand, "@returnMessage").ToString();

										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
											dbCommand.Connection.Dispose();
										}

								}
							 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable Funcitons_List()
			  { 
					DataTable dsDataTable=new DataTable(); 

					try{

						 Database db = new SqlDatabase(db_connectionstring);
					 

							using(DbCommand dbCommand = db.GetStoredProcCommand("Funcitons_List"))
							{
							
								
								
								dsDataTable = db.ExecuteDataSet(dbCommand).Tables[0];

									if (dbCommand.Connection.State != ConnectionState.Closed)
                    				{
										 dbCommand.Connection.Dispose();
									}
							}

						 

					}catch{
						throw;
					}


					return dsDataTable;	


					 

			   }
			   
			 
public virtual System.Data.DataTable get_all_Funcitons(string tenantid)
			  { 

				    DataTable dsDataTable=new DataTable(); 

					try{

						 Database db = new SqlDatabase(db_connectionstring);
						
							using(DbCommand dbCommand = db.GetStoredProcCommand("get_sp_all_Funcitons"))
							{
								
								
								
								db.AddInParameter(dbCommand,"@tenantid",DbType.String,tenantid);
								dsDataTable = db.ExecuteDataSet(dbCommand).Tables[0];

									if (dbCommand.Connection.State != ConnectionState.Closed)
                    				{
										 dbCommand.Connection.Dispose();
									}

							}
						

					}catch{
						throw;
					}
					return dsDataTable;	


					 

			   }
public virtual System.Data.DataSet getById_sp_all_Funcitons(string Funcitonsid)
			 {
				DataSet dsDataSet=new DataSet();
				try{
					    Database db = new SqlDatabase(db_connectionstring);
					 
						using(DbCommand dbCommand = db.GetStoredProcCommand("getById_sp_all_Funcitons"))
						{

							db.AddInParameter(dbCommand,"@Funcitonsid",DbType.String,Funcitonsid);
							dsDataSet = db.ExecuteDataSet(dbCommand);
									if (dbCommand.Connection.State != ConnectionState.Closed)
                    				{
										 dbCommand.Connection.Dispose();
									}

						}
					 
				}catch{
						throw;
				}
				return dsDataSet;
			 }
			  public virtual string  verify_Funcitons(string Funcitonsid,string verifiedby,string verifiedstatus,string reviewcomments)
			 { 
				 String ResponseMessage="";
					try{
						 	Database db = new SqlDatabase(db_connectionstring);
						
							using(DbCommand dbCommand = db.GetStoredProcCommand("verify_Funcitons"))
							{
								db.AddInParameter(dbCommand,"@Funcitonsid",DbType.String,Funcitonsid);
								db.AddInParameter(dbCommand,"@verifiedby",DbType.String,verifiedby);
								db.AddInParameter(dbCommand,"@verifiedstatus",DbType.String,verifiedstatus);
								db.AddInParameter(dbCommand,"@reviewcomments",DbType.String,reviewcomments); 	
								db.AddOutParameter(dbCommand,"@returnMessage",DbType.String,4000);
								db.ExecuteNonQuery(dbCommand);
								ResponseMessage = db.GetParameterValue(dbCommand, "@returnMessage").ToString();

									if (dbCommand.Connection.State != ConnectionState.Closed)
                    				{
										 dbCommand.Connection.Dispose();
									}
							}
						 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable lookup_Funcitons_industryname()
							{
								DataTable dsDataTable=new DataTable();
								try{
									    Database db = new SqlDatabase(db_connectionstring);
									 	using(DbCommand dbCommand = db.GetStoredProcCommand("lookup_Funcitons_industryname"))
										{
											
											dsDataTable = db.ExecuteDataSet(dbCommand).Tables[0];

											if (dbCommand.Connection.State != ConnectionState.Closed)
											{
												dbCommand.Connection.Dispose();
											}
										}

									 
								}catch{
									throw;
								}
								return dsDataTable;
							}
public virtual System.Data.DataTable lookup_Funcitons_industrytypename(String industryname)
							{
								DataTable dsDataTable=new DataTable();
								try{
									    Database db = new SqlDatabase(db_connectionstring);
									 	using(DbCommand dbCommand = db.GetStoredProcCommand("lookup_Funcitons_industrytypename"))
										{
											db.AddInParameter(dbCommand,"@industryname",DbType.String,industryname);
											dsDataTable = db.ExecuteDataSet(dbCommand).Tables[0];

											if (dbCommand.Connection.State != ConnectionState.Closed)
											{
												dbCommand.Connection.Dispose();
											}
										}

									 
								}catch{
									throw;
								}
								return dsDataTable;
							}
public virtual System.Data.DataTable lookup_Funcitons_subtypename(String industryname,String industrytypename)
							{
								DataTable dsDataTable=new DataTable();
								try{
									    Database db = new SqlDatabase(db_connectionstring);
									 	using(DbCommand dbCommand = db.GetStoredProcCommand("lookup_Funcitons_subtypename"))
										{
											db.AddInParameter(dbCommand,"@industryname",DbType.String,industryname);db.AddInParameter(dbCommand,"@industrytypename",DbType.String,industrytypename);
											dsDataTable = db.ExecuteDataSet(dbCommand).Tables[0];

											if (dbCommand.Connection.State != ConnectionState.Closed)
											{
												dbCommand.Connection.Dispose();
											}
										}

									 
								}catch{
									throw;
								}
								return dsDataTable;
							}








			}


			}
