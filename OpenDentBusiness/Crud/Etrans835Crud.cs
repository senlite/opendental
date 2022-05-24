//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class Etrans835Crud {
		///<summary>Gets one Etrans835 object from the database using the primary key.  Returns null if not found.</summary>
		public static Etrans835 SelectOne(long etrans835Num) {
			string command="SELECT * FROM etrans835 "
				+"WHERE Etrans835Num = "+POut.Long(etrans835Num);
			List<Etrans835> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Etrans835 object from the database using a query.</summary>
		public static Etrans835 SelectOne(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Etrans835> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Etrans835 objects from the database using a query.</summary>
		public static List<Etrans835> SelectMany(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Etrans835> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Etrans835> TableToList(DataTable table) {
			List<Etrans835> retVal=new List<Etrans835>();
			Etrans835 etrans835;
			foreach(DataRow row in table.Rows) {
				etrans835=new Etrans835();
				etrans835.Etrans835Num     = PIn.Long  (row["Etrans835Num"].ToString());
				etrans835.EtransNum        = PIn.Long  (row["EtransNum"].ToString());
				etrans835.PayerName        = PIn.String(row["PayerName"].ToString());
				etrans835.TransRefNum      = PIn.String(row["TransRefNum"].ToString());
				etrans835.InsPaid          = PIn.Double(row["InsPaid"].ToString());
				etrans835.ControlId        = PIn.String(row["ControlId"].ToString());
				etrans835.PaymentMethodCode= PIn.String(row["PaymentMethodCode"].ToString());
				etrans835.PatientName      = PIn.String(row["PatientName"].ToString());
				etrans835.Status           = (OpenDentBusiness.X835Status)PIn.Int(row["Status"].ToString());
				etrans835.AutoProcessed    = (OpenDentBusiness.X835AutoProcessed)PIn.Int(row["AutoProcessed"].ToString());
				etrans835.IsApproved       = PIn.Bool  (row["IsApproved"].ToString());
				retVal.Add(etrans835);
			}
			return retVal;
		}

		///<summary>Converts a list of Etrans835 into a DataTable.</summary>
		public static DataTable ListToTable(List<Etrans835> listEtrans835s,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Etrans835";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("Etrans835Num");
			table.Columns.Add("EtransNum");
			table.Columns.Add("PayerName");
			table.Columns.Add("TransRefNum");
			table.Columns.Add("InsPaid");
			table.Columns.Add("ControlId");
			table.Columns.Add("PaymentMethodCode");
			table.Columns.Add("PatientName");
			table.Columns.Add("Status");
			table.Columns.Add("AutoProcessed");
			table.Columns.Add("IsApproved");
			foreach(Etrans835 etrans835 in listEtrans835s) {
				table.Rows.Add(new object[] {
					POut.Long  (etrans835.Etrans835Num),
					POut.Long  (etrans835.EtransNum),
					            etrans835.PayerName,
					            etrans835.TransRefNum,
					POut.Double(etrans835.InsPaid),
					            etrans835.ControlId,
					            etrans835.PaymentMethodCode,
					            etrans835.PatientName,
					POut.Int   ((int)etrans835.Status),
					POut.Int   ((int)etrans835.AutoProcessed),
					POut.Bool  (etrans835.IsApproved),
				});
			}
			return table;
		}

		///<summary>Inserts one Etrans835 into the database.  Returns the new priKey.</summary>
		public static long Insert(Etrans835 etrans835) {
			return Insert(etrans835,false);
		}

		///<summary>Inserts one Etrans835 into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Etrans835 etrans835,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				etrans835.Etrans835Num=ReplicationServers.GetKey("etrans835","Etrans835Num");
			}
			string command="INSERT INTO etrans835 (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="Etrans835Num,";
			}
			command+="EtransNum,PayerName,TransRefNum,InsPaid,ControlId,PaymentMethodCode,PatientName,Status,AutoProcessed,IsApproved) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(etrans835.Etrans835Num)+",";
			}
			command+=
				     POut.Long  (etrans835.EtransNum)+","
				+"'"+POut.String(etrans835.PayerName)+"',"
				+"'"+POut.String(etrans835.TransRefNum)+"',"
				+		 POut.Double(etrans835.InsPaid)+","
				+"'"+POut.String(etrans835.ControlId)+"',"
				+"'"+POut.String(etrans835.PaymentMethodCode)+"',"
				+"'"+POut.String(etrans835.PatientName)+"',"
				+    POut.Int   ((int)etrans835.Status)+","
				+    POut.Int   ((int)etrans835.AutoProcessed)+","
				+    POut.Bool  (etrans835.IsApproved)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				etrans835.Etrans835Num=Db.NonQ(command,true,"Etrans835Num","etrans835");
			}
			return etrans835.Etrans835Num;
		}

		///<summary>Inserts one Etrans835 into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Etrans835 etrans835) {
			return InsertNoCache(etrans835,false);
		}

		///<summary>Inserts one Etrans835 into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Etrans835 etrans835,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO etrans835 (";
			if(!useExistingPK && isRandomKeys) {
				etrans835.Etrans835Num=ReplicationServers.GetKeyNoCache("etrans835","Etrans835Num");
			}
			if(isRandomKeys || useExistingPK) {
				command+="Etrans835Num,";
			}
			command+="EtransNum,PayerName,TransRefNum,InsPaid,ControlId,PaymentMethodCode,PatientName,Status,AutoProcessed,IsApproved) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(etrans835.Etrans835Num)+",";
			}
			command+=
				     POut.Long  (etrans835.EtransNum)+","
				+"'"+POut.String(etrans835.PayerName)+"',"
				+"'"+POut.String(etrans835.TransRefNum)+"',"
				+	   POut.Double(etrans835.InsPaid)+","
				+"'"+POut.String(etrans835.ControlId)+"',"
				+"'"+POut.String(etrans835.PaymentMethodCode)+"',"
				+"'"+POut.String(etrans835.PatientName)+"',"
				+    POut.Int   ((int)etrans835.Status)+","
				+    POut.Int   ((int)etrans835.AutoProcessed)+","
				+    POut.Bool  (etrans835.IsApproved)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				etrans835.Etrans835Num=Db.NonQ(command,true,"Etrans835Num","etrans835");
			}
			return etrans835.Etrans835Num;
		}

		///<summary>Updates one Etrans835 in the database.</summary>
		public static void Update(Etrans835 etrans835) {
			string command="UPDATE etrans835 SET "
				+"EtransNum        =  "+POut.Long  (etrans835.EtransNum)+", "
				+"PayerName        = '"+POut.String(etrans835.PayerName)+"', "
				+"TransRefNum      = '"+POut.String(etrans835.TransRefNum)+"', "
				+"InsPaid          =  "+POut.Double(etrans835.InsPaid)+", "
				+"ControlId        = '"+POut.String(etrans835.ControlId)+"', "
				+"PaymentMethodCode= '"+POut.String(etrans835.PaymentMethodCode)+"', "
				+"PatientName      = '"+POut.String(etrans835.PatientName)+"', "
				+"Status           =  "+POut.Int   ((int)etrans835.Status)+", "
				+"AutoProcessed    =  "+POut.Int   ((int)etrans835.AutoProcessed)+", "
				+"IsApproved       =  "+POut.Bool  (etrans835.IsApproved)+" "
				+"WHERE Etrans835Num = "+POut.Long(etrans835.Etrans835Num);
			Db.NonQ(command);
		}

		///<summary>Updates one Etrans835 in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Etrans835 etrans835,Etrans835 oldEtrans835) {
			string command="";
			if(etrans835.EtransNum != oldEtrans835.EtransNum) {
				if(command!="") { command+=",";}
				command+="EtransNum = "+POut.Long(etrans835.EtransNum)+"";
			}
			if(etrans835.PayerName != oldEtrans835.PayerName) {
				if(command!="") { command+=",";}
				command+="PayerName = '"+POut.String(etrans835.PayerName)+"'";
			}
			if(etrans835.TransRefNum != oldEtrans835.TransRefNum) {
				if(command!="") { command+=",";}
				command+="TransRefNum = '"+POut.String(etrans835.TransRefNum)+"'";
			}
			if(etrans835.InsPaid != oldEtrans835.InsPaid) {
				if(command!="") { command+=",";}
				command+="InsPaid = "+POut.Double(etrans835.InsPaid)+"";
			}
			if(etrans835.ControlId != oldEtrans835.ControlId) {
				if(command!="") { command+=",";}
				command+="ControlId = '"+POut.String(etrans835.ControlId)+"'";
			}
			if(etrans835.PaymentMethodCode != oldEtrans835.PaymentMethodCode) {
				if(command!="") { command+=",";}
				command+="PaymentMethodCode = '"+POut.String(etrans835.PaymentMethodCode)+"'";
			}
			if(etrans835.PatientName != oldEtrans835.PatientName) {
				if(command!="") { command+=",";}
				command+="PatientName = '"+POut.String(etrans835.PatientName)+"'";
			}
			if(etrans835.Status != oldEtrans835.Status) {
				if(command!="") { command+=",";}
				command+="Status = "+POut.Int   ((int)etrans835.Status)+"";
			}
			if(etrans835.AutoProcessed != oldEtrans835.AutoProcessed) {
				if(command!="") { command+=",";}
				command+="AutoProcessed = "+POut.Int   ((int)etrans835.AutoProcessed)+"";
			}
			if(etrans835.IsApproved != oldEtrans835.IsApproved) {
				if(command!="") { command+=",";}
				command+="IsApproved = "+POut.Bool(etrans835.IsApproved)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE etrans835 SET "+command
				+" WHERE Etrans835Num = "+POut.Long(etrans835.Etrans835Num);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Etrans835,Etrans835) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Etrans835 etrans835,Etrans835 oldEtrans835) {
			if(etrans835.EtransNum != oldEtrans835.EtransNum) {
				return true;
			}
			if(etrans835.PayerName != oldEtrans835.PayerName) {
				return true;
			}
			if(etrans835.TransRefNum != oldEtrans835.TransRefNum) {
				return true;
			}
			if(etrans835.InsPaid != oldEtrans835.InsPaid) {
				return true;
			}
			if(etrans835.ControlId != oldEtrans835.ControlId) {
				return true;
			}
			if(etrans835.PaymentMethodCode != oldEtrans835.PaymentMethodCode) {
				return true;
			}
			if(etrans835.PatientName != oldEtrans835.PatientName) {
				return true;
			}
			if(etrans835.Status != oldEtrans835.Status) {
				return true;
			}
			if(etrans835.AutoProcessed != oldEtrans835.AutoProcessed) {
				return true;
			}
			if(etrans835.IsApproved != oldEtrans835.IsApproved) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Etrans835 from the database.</summary>
		public static void Delete(long etrans835Num) {
			string command="DELETE FROM etrans835 "
				+"WHERE Etrans835Num = "+POut.Long(etrans835Num);
			Db.NonQ(command);
		}

		///<summary>Deletes many Etrans835s from the database.</summary>
		public static void DeleteMany(List<long> listEtrans835Nums) {
			if(listEtrans835Nums==null || listEtrans835Nums.Count==0) {
				return;
			}
			string command="DELETE FROM etrans835 "
				+"WHERE Etrans835Num IN("+string.Join(",",listEtrans835Nums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}