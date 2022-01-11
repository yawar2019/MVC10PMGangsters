using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DapperEmple.Models;

namespace DapperEmple.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public ActionResult Index()
        {
            List<EmployeeModel> _listEmp = con.Query<EmployeeModel>("select * FROM [Employee].[dbo].[employeeDetails]").ToList();
            return View(_listEmp);
        }
    }
}