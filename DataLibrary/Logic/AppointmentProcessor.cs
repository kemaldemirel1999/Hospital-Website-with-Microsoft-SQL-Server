using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class AppointmentProcessor
    {
        public static List<AppointmentModel> Load()
        {
            string sql = @"select * from dbo.Appointment";
            return SqlDataAccess.LoadData<AppointmentModel>(sql);
        }
        public static int Create(string doctorid, DateTime date, string clinicname,string pssn)
        {
            AppointmentModel data = new AppointmentModel
            {
                Pssn = pssn,
                ClinicName = clinicname,
                Date = date,
                DoctorId = doctorid
            };
            string sql = @"insert into dbo.Appointment(Pssn,ClinicName,Date,DoctorId) values
            (@Pssn,@ClinicName,@Date,@DoctorId)";
            return SqlDataAccess.SaveData<AppointmentModel>(sql, data);
        }
        public static int Edit(string doctorid, DateTime date, string clinicname,string pssn)
        {
            AppointmentModel data = new AppointmentModel
            {
                Pssn = pssn,
                ClinicName = clinicname,
                Date = date,
                DoctorId = doctorid
            };
            //editing docid and date
            string sql = @"update dbo.Appointment set Date=@Date,DoctorId=@DoctorId where (Pssn=@Pssn and ClinicName=@ClinicName)";
            return SqlDataAccess.UpdateData<AppointmentModel>(sql, data);
        }
        public static int Delete(string employeeId,string pssn,string clinicName)
        {
            AppointmentModel data = new AppointmentModel
            {
                DoctorId = employeeId,
                Pssn=pssn,
                ClinicName=clinicName
            };
            string sql = @"delete from dbo.Appointment where (DoctorId=@DoctorId and Pssn=@Pssn and ClinicName=@ClinicName)";
            return SqlDataAccess.DeleteData<AppointmentModel>(sql, data);
        }
    }
}
