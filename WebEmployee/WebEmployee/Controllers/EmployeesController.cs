using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic;
using System.Data;
using System.Linq; 
using WebEmployee.Center;
using WebEmployee.Models;

namespace WebEmployee.Controllers
{
    public class EmployeesController : Controller
    {
        private string sql = "";
        private const string table = "tbEmployee";

        private DBConnect dbConnect = new DBConnect();
         
        public IActionResult ViewEmployees()
        { 
            return View(Wprv_ShowData());
        }

        public IActionResult AddEmployees()
        {
            return View();
        }
         
        public IActionResult SaveEmployees(Employees employees)
        {
            if (employees == null)
            {
                return NotFound();
            }
             
            DataSet ds = new DataSet();
            sql = "SELECT * From " + table + " WHERE ROWAUTO = -1";
            ds = dbConnect.Cpds_ShowDB(sql, table, ds);
            if (ds.Tables[table].Rows.Count <= 0)
            {
                DataRow dr = ds.Tables[table].NewRow();
                dr["Code"] = employees.Code.Trim();
                dr["Name"] = employees.Name.Trim();
                dr["Salary"] = employees.Salary;
                ds.Tables[table].Rows.Add(dr);
                dbConnect.CpsqlDa_returnAda.Update(ds, table);
            }

            return View();
        }

        public IActionResult SearchEmployees(Employees employee)
        {
            return View(employee);
        }

        public IActionResult UpdateEmployees(Employees employees)
        {
            if (employees == null)
            {
                return NotFound();
            }

            DataSet ds = new DataSet();
            sql = "SELECT * From " + table + " WHERE ROWAUTO = " + employees.RowAuto;
            ds = dbConnect.Cpds_ShowDB(sql, table, ds);
            if (ds.Tables[table].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[table].Rows[0];
                dr["Code"] = employees.Code.Trim();
                dr["Name"] = employees.Name.Trim();
                dr["Salary"] = employees.Salary; 
                dbConnect.CpsqlDa_returnAda.Update(ds, table);
            }
            return View();
        }

        public IActionResult DeleteEmployees(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            string sql = "DELETE FROM "+ table +" WHERE Code ='" + id + "'";
            dbConnect.Cpb_Action(sql);
            return View();
        } 
         
        private IEnumerable<Employees> Wprv_ShowData ()
        {
            List<Employees> employees = new List<Employees>();
            DataSet ds = new DataSet();
            sql = "SELECT * From " + table;
            ds = dbConnect.Cpds_ShowDB(sql, table, ds);
             
                DataTable dt = new DataTable(table);
                dt = ds.Tables[table];

                employees = (from DataRow dr in dt.Rows
                             select new Employees()
                             {
                                 RowAuto = int.Parse( dr["RowAuto"].ToString()),
                                 Code = dr["Code"].ToString(),
                                 Name = dr["Name"].ToString(),
                                 Salary = double.Parse(dr["Salary"].ToString()),
                             }).ToList(); 
            return employees;
        }
    }
}