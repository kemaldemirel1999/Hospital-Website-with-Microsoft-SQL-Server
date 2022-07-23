using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class RoomProcessor
    {
        public static List<RoomModel> Load()
        {
            string sql = @"select * from dbo.Room";
            return SqlDataAccess.LoadData<RoomModel>(sql);
        }
        public static int Create(string room)
        {
            RoomModel data = new RoomModel
            {
                RoomNo = room
            };
            string sql = @"insert into dbo.Room(RoomNo) values
            (@RoomNo)";
            return SqlDataAccess.SaveData<RoomModel>(sql, data);
        }
        public static int Edit(string room)
        {
            RoomModel data = new RoomModel
            {
                RoomNo = room
            };
            string sql = @"update dbo.Room set RoomNo=@RoomNo";
            return SqlDataAccess.UpdateData<RoomModel>(sql, data);
        }
        public static int Delete(string roomno)
        {
            RoomModel data = new RoomModel
            {
                RoomNo = roomno
            };
            string sql = @"delete from dbo.Room where RoomNo=@RoomNo";
            return SqlDataAccess.DeleteData<RoomModel>(sql, data);
        }
    }
}
