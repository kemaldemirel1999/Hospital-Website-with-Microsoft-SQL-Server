using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class PrescriptionProcessor
    {
        public static List<PrescriptionModel> Load()
        {
            string sql = @"select * from dbo.Prescription";
            return SqlDataAccess.LoadData<PrescriptionModel>(sql);
        }
        public static int Create(string ssn, string empid, DateTime date, string drug_name, DateTime given_date)
        {
            PrescriptionModel data = new PrescriptionModel
            {
                EmpId = empid,
                Pssn = ssn,
                Date = date,
                Drug_name = drug_name,
                Given_date = given_date
            };
            string sql = @"insert into dbo.Prescription(Pssn,EmpId,Date,Drug_name,Given_date) values
            (@Pssn,@EmpId,@Date,@Drug_name,@Given_date)";
            return SqlDataAccess.SaveData<PrescriptionModel>(sql, data);
        }
        public static int Edit(string ssn, string empid, DateTime date, string drug_name, DateTime given_date)
        {
            PrescriptionModel data = new PrescriptionModel
            {
                EmpId = empid,
                Pssn = ssn,
                Date = date,
                Drug_name = drug_name,
                Given_date = given_date
            };
            string sql = @"update dbo.Prescription set EmpId=@EmpId,Date=@Date,Drug_name=@Drug_name,Given_Date=@Given_Date where Pssn=@Pssn";
            return SqlDataAccess.UpdateData<PrescriptionModel>(sql, data);
        }
        public static int Delete(string pssn,string employeeId)
        {
            PrescriptionModel data = new PrescriptionModel
            {
                EmpId = employeeId,
                Pssn=pssn
            };
            string sql = @"delete from dbo.Prescription where (EmpId=@EmpId and Pssn=@Pssn)";
            return SqlDataAccess.DeleteData<PrescriptionModel>(sql, data);
        }
    }
}
