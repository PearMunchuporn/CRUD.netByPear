using Microsoft.AspNetCore.Mvc;
using CRUD.Controllers;
using CRUD.Models;
using System.Collections.Generic;
using CRUD.Data;

namespace CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDBContext database;

        public EmployeeController(ApplicationDBContext db)
        {
            database = db;
        }
        public IActionResult Index()
        {
            Employee emp1 = new Employee();

            IEnumerable <Employee> allemployees = database.Employees;
            return View(allemployees);

           //get method


        }public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)

        {
           if(ModelState.IsValid)
            {
                database.Employees.Add(emp);
                database.SaveChanges();

                return RedirectToAction("Index"); //Index method
            }
           return View(emp);
        }
        public IActionResult Edit(int? id)
        {
            if(id==null || id ==0)
            {
                return NotFound();
            }
            var emp = database.Employees.Find(id);
            if(emp==null)
            {
                return NotFound();
            }
            return View(emp);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee emp)

        {
            if (ModelState.IsValid)
            {
                database.Employees.Update(emp);
                database.SaveChanges();

                return RedirectToAction("Index"); //Index method
            }
            return View(emp);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var emp = database.Employees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            database.Employees.Remove(emp);
            database.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
