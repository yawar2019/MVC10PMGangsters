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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);

            int i= con.Execute("sp_CreateEmployee", param:param,commandType:CommandType.StoredProcedure);
            if (i > 0)
                return RedirectToAction("Index");
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", id);

            var Emp = con.QuerySingle<EmployeeModel>("sp_getNeerjaEmployeeDetailsById",param:param, commandType: CommandType.StoredProcedure);

            return View(Emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", emp.EmpId);
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);

            int i = con.Execute("sp_UpdateNeerjaEmployees", param: param, commandType: CommandType.StoredProcedure);
            if (i > 0)
                return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", id);

            var Emp = con.QuerySingle<EmployeeModel>("sp_getNeerjaEmployeeDetailsById", param: param, commandType: CommandType.StoredProcedure);

            return View(Emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", id);

            int i = con.Execute("sp_RajaDeleteEmployee", param: param, commandType: CommandType.StoredProcedure);
            if (i > 0)
                return RedirectToAction("Index");
            return View();
        }

        public ViewResult HtmlHelperExample()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Srikanth";
            return View(emp);

        }
        public ViewResult HtmlHelperExample2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Srikanth";
            return View(emp);

        }

    }
}