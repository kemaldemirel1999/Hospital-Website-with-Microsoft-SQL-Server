using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class NurseProcessor
    {
        public static List<NurseModel> Load()
        {
            string sql = @"select * from dbo.Nurse";
            return SqlDataAccess.LoadData<NurseModel>(sql);
        }
        public static int Create(string empid, string room)
        {
            NurseModel data = new NurseModel
            {
                EmpId = empid,
                Room_responsible = room
            };
            string sql = @"insert into dbo.Nurse(EmpId,Room_responsible) values
            (@EmpId,@Room_responsible)";
            return SqlDataAccess.SaveData<NurseModel>(sql, data);
        }
        public static int Edit(string empid, string room)
        {
            NurseModel data = new NurseModel
            {
                EmpId= empid,
                Room_responsible=room
            };
            string sql = @"update dbo.Nurse set Room_responsible=@Room_responsible where EmpId=@EmpId";
            return SqlDataAccess.UpdateData<NurseModel>(sql, data);
        }
        public static int Delete(string employeeId)
        {
            NurseModel data = new NurseModel
            {
                EmpId = employeeId
            };
            string sql = @"delete from dbo.Nurse where EmpId=@EmpId";
            return SqlDataAccess.DeleteData<NurseModel>(sql, data);
        }
    }
}
