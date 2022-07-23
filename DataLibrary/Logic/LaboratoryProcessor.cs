using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class LaboratoryProcessor
    {
        public static List<LaboratoryModel> Load()
        {
            string sql = @"select * from dbo.Laboratory";
            return SqlDataAccess.LoadData<LaboratoryModel>(sql);
        }
        public static int Create(string supervisor, string labno)
        {
            LaboratoryModel data = new LaboratoryModel
            {
                Supervisor_name  = supervisor,
                Room_no = labno
            };
            string sql = @"insert into dbo.Laboratory(Room_no,Supervisor_name) values
            (@Room_no,@Supervisor_name)";
            return SqlDataAccess.SaveData<LaboratoryModel>(sql, data);
        }
        public static int Edit(string supervisor, string labno)
        {
            LaboratoryModel data = new LaboratoryModel
            {
                Supervisor_name = supervisor,
                Room_no = labno
            };
            string sql = @"update dbo.Laboratory set Supervisor_name=@Supervisor_name where Room_no=@Room_no";
            return SqlDataAccess.UpdateData<LaboratoryModel>(sql, data);
        }
        public static int Delete(string roomno)
        {
            LaboratoryModel data = new LaboratoryModel
            {
                Room_no = roomno
            };
            string sql = @"delete from dbo.Laboratory where Room_no=@Room_no";
            return SqlDataAccess.DeleteData<LaboratoryModel>(sql, data);
        }
    }
}
