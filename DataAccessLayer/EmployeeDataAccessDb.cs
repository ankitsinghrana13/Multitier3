using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data;
using CommanLayer.Models;
using Microsoft.Data.SqlClient;
using System.Collections;
using CommanLayer;
//using DataAccessLayer;
//using DataAccessLayer

namespace DataAccessLayer
{
    public class EmployeeDataAccessDb
    {

        private DbConnecton db = new DbConnecton();
        public List<Employees> GetEmployees()
        {
            string query = "select * from Customers";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.Cnn;
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Employees> employees = new List<Employees>();
            while (reader.Read())
            {
                Employees emp = new Employees();
                emp.Id = (int)reader["Id"];
                emp.Name = reader["Name"].ToString();
                emp.Email = reader["Email"].ToString();
                //emp.Mobile = reader["Mobile"].ToString();
                employees.Add(emp);
            }
            db.Cnn.Close();
            return employees;
        }
           /* 
     public List<Employees> GetEmployees()
        {
            string query = "select * from Customer";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.Cnn;
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            
           
            // List<Employees> employees = new List<Employees>();
            while (reader.Read())
            {
                
            }
            * {
                Employees emp = new Employees();
                emp.
                emp.Id = (int)reader["Id"];
                emp.Name = reader["Name"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.Mobile = reader["Mobile"].ToString();
                employees.Add(emp);
            }*/
            
        
    }
}
