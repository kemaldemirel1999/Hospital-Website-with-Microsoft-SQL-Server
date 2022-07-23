using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class DoctorProcessor
    {
        public static List<DoctorModel> Load()
        {
            string sql = @"select * from dbo.Doctor";
            return SqlDataAccess.LoadData<DoctorModel>(sql);
        }
        public static int Create(string empid, string clinic, string branch)
        {
            DoctorModel data = new DoctorModel
            {
                EmpId = empid,
                Clinic_name = clinic,
                Branch=branch
            };
            string sql = @"insert into dbo.Doctor(EmpId,Clinic_name,Branch) values
            (@EmpId,@Clinic_name,@Branch)";
            return SqlDataAccess.SaveData<DoctorModel>(sql, data);
        }
        public static int Edit(string empid, string headid, string branch)
        {
            DoctorModel data = new DoctorModel
            {
                EmpId = empid,
                Clinic_name = headid,
                Branch=branch
            };
            string sql = @"update dbo.Doctor set Clinic_name=@Clinic_name,Branch=@Branch where EmpId=@EmpId";
            return SqlDataAccess.UpdateData<DoctorModel>(sql, data);
        }
        public static int Delete(string employeeId)
        {
            DoctorModel data = new DoctorModel
            {
                EmpId = employeeId
            };
            string sql = @"delete from dbo.Doctor where EmpId=@EmpId";
            return SqlDataAccess.DeleteData<DoctorModel>(sql, data);

        }
    }
}
