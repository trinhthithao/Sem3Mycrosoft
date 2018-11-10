﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameWorkDatabaseFirst.Models;

namespace EntityFrameWorkDatabaseFirst.Controllers
{
    public class EmployeeController : Controller
    {
        HR14Entities2 db = new HR14Entities2();

        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();  
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}