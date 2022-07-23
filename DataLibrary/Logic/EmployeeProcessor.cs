using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class EmployeeProcessor
    {
        public static List<EmployeeModel> Load()
        {
            string sql = @"select * from dbo.Employee";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
        public static int Create(string empid, string fname, string sname,string phone,char gender,string addres, string salary)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId=empid,
                FirstName=fname,
                Surname=sname,
                Phone=phone,
                Salary=salary,
                Address=addres,
                Gender=gender
            };
            string sql = @"insert into dbo.Employee(EmployeeId,FirstName,Surname,Phone,Gender,Address,Salary) values
            (@EmployeeId,@FirstName,@Surname,@Phone,@Gender,@Address,@Salary)";
            return SqlDataAccess.SaveData<EmployeeModel>(sql, data);
        }
        public static int Edit(string empid, string fname , string sname, string phone, char gender ,string addres, string salary)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = empid,
                FirstName = fname,
                Surname = sname,
                Phone = phone,
                Gender = gender,
                Salary = salary,
                Address = addres,
            };
            string sql = @"update dbo.Employee set Phone=@Phone,Salary=@Salary,Address=@Address where EmployeeId=@EmployeeId";
            return SqlDataAccess.UpdateData<EmployeeModel>(sql, data);
        }
        public static int Delete(string employeeId)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId
            };
            string sql = @"delete from dbo.Employee where EmployeeId=@EmployeeId";
            return SqlDataAccess.DeleteData<EmployeeModel>(sql,data);
        }
    }
}
