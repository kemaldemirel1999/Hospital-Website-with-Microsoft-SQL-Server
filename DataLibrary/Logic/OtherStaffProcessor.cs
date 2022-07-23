using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class OtherStaffProcessor
    {
        public static List<OtherStaffModel> Load()
        {
            string sql = @"select * from dbo.OtherStaff";
            return SqlDataAccess.LoadData<OtherStaffModel>(sql);
        }
        public static int Create(string managerid)
        {
            OtherStaffModel data = new OtherStaffModel
            {
                EmpId = managerid
            };
            string sql = @"insert into dbo.OtherStaff(EmpId) values
            (@EmpId)";
            return SqlDataAccess.SaveData<OtherStaffModel>(sql, data);
        }
        public static int Edit(string managerid)
        {
            OtherStaffModel data = new OtherStaffModel
            {
                EmpId = managerid
            };
            string sql = @"update dbo.OtherStaff set EmpId=@EmpId";
            return SqlDataAccess.UpdateData<OtherStaffModel>(sql, data);
        }
        public static int Delete(string employeeId)
        {
            OtherStaffModel data = new OtherStaffModel
            {
                EmpId = employeeId
            };
            string sql = @"delete from dbo.OtherStaff where EmpId=@EmpId";
            return SqlDataAccess.DeleteData<OtherStaffModel>(sql, data);
        }
    }
}
