namespace MVCBusinessLogic.library
{
    public class Program
    {

    }
}

using MVC_BusinessEntities;  
using System;  
using System.Collections.Generic;  
using System.Configuration;  
using System.Data;  
using System.Data.SqlClient;  
namespace MVCBusinessLogic.library
{
    public class DL_Employee
    {
        public IEnumerable<BE_Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                List<BE_Employee> employees = new List<BE_Employee>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_GetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@DeptId", null);   
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        BE_Employee employee = new BE_Employee();
                        employee.ID = Convert.ToInt32(rdr["Id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.Gender = rdr["Gender"].ToString();
                        employee.Salary = Convert.ToInt32(rdr["Salary"]);
                        employee.DeptId = Convert.ToInt32(rdr["DeptId"]);
                        employees.Add(employee);
                    }
                }
                return employees;
            }
        }
    }
}
