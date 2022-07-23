using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class ManagerProcessor
    {
        public static List<ManagerModel> Load()
        {
            string sql = @"select * from dbo.Manager";
            return SqlDataAccess.LoadData<ManagerModel>(sql);
        }
        public static int Create(string managerid)
        {
            ManagerModel data = new ManagerModel
            {
                EmpId = managerid
            };
            string sql = @"insert into dbo.Manager(EmpId) values
            (@EmpId)";
            return SqlDataAccess.SaveData<ManagerModel>(sql, data);
        }
        public static int Edit(string managerid)
        {
            ManagerModel data = new ManagerModel
            {
                EmpId = managerid
            };
            string sql = @"update dbo.Manager set EmpId=@EmpId";
            return SqlDataAccess.UpdateData<ManagerModel>(sql, data);
        }
        public static int Delete(string employeeId)
        {
            ManagerModel data = new ManagerModel
            {
                EmpId = employeeId
            };
            string sql = @"delete from dbo.Manager where EmpId=@EmpId";
            return SqlDataAccess.DeleteData<ManagerModel>(sql, data);
        }
    }
}
