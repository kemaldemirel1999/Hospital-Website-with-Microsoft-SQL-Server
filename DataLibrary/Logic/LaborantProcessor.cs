using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class LaborantProcessor
    {
        public static List<LaborantModel> Load()
        {
            string sql = @"select * from dbo.Laborant";
            return SqlDataAccess.LoadData<LaborantModel>(sql);
        }
        public static int Create(string empid, string labno)
        {
            LaborantModel data = new LaborantModel
            {
                EmpId = empid,
                Lab_no=labno
            };
            string sql = @"insert into dbo.Laborant(EmpId,Lab_no) values
            (@EmpId,@Lab_no)";
            return SqlDataAccess.SaveData<LaborantModel>(sql, data);
        }
        public static int Edit(string empid, string labno)
        {
            LaborantModel data = new LaborantModel
            {
                EmpId = empid,
                Lab_no = labno,
            };
            string sql = @"update dbo.Laborant set Lab_no=@Lab_no where EmpId=@EmpId";
            return SqlDataAccess.UpdateData<LaborantModel>(sql, data);
        }
        public static int Delete(string employeeId,string labno)
        {
            LaborantModel data = new LaborantModel
            {
                EmpId = employeeId,
                Lab_no=labno
            };
            string sql = @"delete from dbo.Laborant where EmpId=@EmpId and Lab_no=@Lab_no";
            return SqlDataAccess.DeleteData<LaborantModel>(sql, data);
        }
    }
}
