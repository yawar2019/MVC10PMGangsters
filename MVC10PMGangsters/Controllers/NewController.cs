﻿using MVC10PMGangsters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10PMGangsters.Controllers
{
    public class NewController : Controller
    {
        // GET: New/index/1212?Name=suresh&Designation=Tester&Department=ECE
        public string Index(string id,string Name,string Designation)
        {
            return "Hi My Id is "+id+" ,Name is "+Name+" My Designation "+Designation;
        }

        public string Index4(string id)
        {
            return "Hi My Id is " + id + " ,Name is " + Request.QueryString["Name"] + " My Designation " + Request.QueryString["Designation"] ;
        }


        public string Index2(int? id)
        {
            return "My Employee id is  "+id;
        }

        public ActionResult Index3()
        {
            return View();
        }

       // [Route("jungle/Tiger/{id:int}")]
        [Route("jungle/Tiger/{id:alpha}")]
        [Route("jungle/Lion")]
        [Route("jungle/Cheetah")]
        [Route("new/Index6")]
        
        public ActionResult Index6(string id)
        {
            return View();
        }

        public ActionResult Index7()
        {

            ViewBag.MiddleName = "Mr.Aakash";
            return View();
        }
        public ActionResult Index8()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Aakash";
            emp.EmpSalary = 34567;

            ViewBag.employee = emp;
            return View();
        }

        public ActionResult Index9()
        {
            List<EmployeeModel> listemp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Aakash";
            emp.EmpSalary = 34567;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Nirmala";
            emp1.EmpSalary = 34554;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "prasad";
            emp2.EmpSalary = 34567;

            listemp.Add(emp);
            listemp.Add(emp1);
            listemp.Add(emp2);



            ViewBag.employee = listemp;
            return View();
        }


        public ActionResult Index10()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Kiran";
            emp.EmpSalary = 34567;

                        //object model=emp;
            return View(emp);
        }


        public ActionResult Index11()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Kiran";
            emp.EmpSalary = 34567;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Suresh";
            emp1.EmpSalary = 673839;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Asha";
            emp2.EmpSalary = 74567;


            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            //object model=listEmp;
            return View(listEmp);
        }

        public ActionResult Index12()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Kiran";
            emp.EmpSalary = 34567;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Suresh";
            emp1.EmpSalary = 673839;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Asha";
            emp2.EmpSalary = 74567;


            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            List<DepartmentModel> listdept = new List<DepartmentModel>();

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1;
            dept1.DeptName = "IT";
            dept1.Head = "Asha";

            DepartmentModel dept2 = new Models.DepartmentModel();
            dept2.DeptId = 2;
            dept2.DeptName = "Network";
            dept2.Head = "Suresh";

            DepartmentModel dept3 = new Models.DepartmentModel();
            dept3.DeptId = 3;
            dept3.DeptName = "Marketing";
            dept3.Head = "Rama";

            listdept.Add(dept1);
            listdept.Add(dept2);
            listdept.Add(dept3);

            EmpDept Emodel = new EmpDept();
            Emodel.emp = listEmp;
            Emodel.dept = listdept;


            //object model=listEmp;
            return View(Emodel);
        }

    }
}

//yawarali17@gmail.com