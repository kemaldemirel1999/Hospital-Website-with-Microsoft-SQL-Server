using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class ClinicProcessor
    {
        public static List<ClinicModel> Load()
        {
            string sql = @"select * from dbo.Clinic";
            return SqlDataAccess.LoadData<ClinicModel>(sql);
        }
        public static int Create(string headdoc,string location, string name)
        {
            ClinicModel data = new ClinicModel
            {
                HeadDoctorId=headdoc,
                Location=location,
                Name=name
            };
            string sql = @"insert into dbo.Clinic(HeadDoctorId,Location,Name) values
            (@HeadDoctorId,@Location,@Name)";
            return SqlDataAccess.SaveData<ClinicModel>(sql, data);
        }
        public static int Edit(string headdoc, string location, string name)
        {
            ClinicModel data = new ClinicModel
            {
                HeadDoctorId = headdoc,
                Location = location,
                Name = name
            };
            string sql = @"update dbo.Clinic set HeadDoctorId=@HeadDoctorId,Location=@Location where Name=@Name";
            return SqlDataAccess.UpdateData<ClinicModel>(sql, data);
        }
        public static int Delete(string name)
        {
            ClinicModel data = new ClinicModel
            {
                Name = name
            };
            string sql = @"delete from dbo.Clinic where Name=@Name";
            return SqlDataAccess.DeleteData<ClinicModel>(sql, data);
        }
    }
}
