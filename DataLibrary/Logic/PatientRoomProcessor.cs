using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class PatientRoomProcessor
    {
        public static List<PatientRoomModel> Load()
        {
            string sql = @"select * from dbo.PatientRoom";
            return SqlDataAccess.LoadData<PatientRoomModel>(sql);
        }
        public static int Create(string room,string ssn, string capacity)
        {
            PatientRoomModel data = new PatientRoomModel
            {
                Room_no=room,
                Pssn=ssn,
                Capacity=capacity
            };
            string sql = @"insert into dbo.PatientRoom(Room_no,Pssn,Capacity) values
            (@Room_no,@Pssn,@Capacity)";
            return SqlDataAccess.SaveData<PatientRoomModel>(sql, data);
        }
        public static int Edit(string room, string ssn, string capacity)
        {
            PatientRoomModel data = new PatientRoomModel
            {
                Room_no=room,
                Pssn=ssn,
                Capacity=capacity
            };
            string sql = @"update dbo.PatientRoom set Pssn=@Pssn,Capacity=@Capacity where Room_no=@Room_no";
            return SqlDataAccess.UpdateData<PatientRoomModel>(sql, data);
        }
        public static int Delete(string roomno)
        {
            PatientRoomModel data = new PatientRoomModel
            {
                Room_no=roomno
            };
            string sql = @"delete from dbo.PatientRoom where Room_no=@Room_no";
            return SqlDataAccess.DeleteData<PatientRoomModel>(sql, data);
        }
    }
}
