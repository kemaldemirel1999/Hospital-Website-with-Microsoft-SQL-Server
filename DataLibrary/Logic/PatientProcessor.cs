using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class PatientProcessor
    {
        public static List<PatientModel> Load()
        {
            string sql = @"select * from dbo.Patient";
            return SqlDataAccess.LoadData<PatientModel>(sql);
        }
        public static int Create(string ssn, string fname, string sname, string phone,DateTime birthdate ,char gender, string address)
        {
            PatientModel data = new PatientModel
            {
                Ssn = ssn,
                FirstName = fname,
                Surname = sname,
                Phone = phone,
                Birthdate = birthdate,
                Address = address,
                Gender = gender
            };
            string sql = @"insert into dbo.Patient(Ssn,FirstName,Surname,Phone,Birthdate,Gender,Address) values
            (@Ssn,@FirstName,@Surname,@Phone,@Birthdate,@Gender,@Address)";
            return SqlDataAccess.SaveData<PatientModel>(sql, data);
        }
        public static int Edit(string ssn, string phone, DateTime birthdate, string address)
        {
            PatientModel data = new PatientModel
            {
                Ssn = ssn,
                Phone = phone,
                Birthdate = birthdate,
                Address = address,
            };
            string sql = @"update dbo.Patient set Phone=@Phone,Birthdate=@Birthdate,Address=@Address where Ssn=@Ssn";
            return SqlDataAccess.UpdateData<PatientModel>(sql, data);
        }
        public static int Delete(string ssn)
        {
            PatientModel data = new PatientModel
            {
                Ssn = ssn
            };
            string sql = @"delete from dbo.Patient where Ssn=@Ssn";
            return SqlDataAccess.DeleteData<PatientModel>(sql, data);
        }
    }
}
