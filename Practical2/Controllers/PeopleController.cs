using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;   
using System.Web.Helpers;
using System.Web.Mvc;
using Practical2.Models;

namespace Practical2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {

            return View();
        }

     public static  List<PersonModel> people = new List<PersonModel>() 
        {
            new PersonModel{
                StuNumber = "u24594394",
                FirstName = "Mohamed Yaseen ",
                LastName = "Munshi",
                Email = "u24594394@tuks.co.za",


            },
            new Models.PersonModel
            {
                StuNumber = "u12345678",
                FirstName = "John ",
                LastName = "Pork",
                Email = "u12345678@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u24765432",
                FirstName = "Tim",
                LastName = "Cheese",
                Email = "u98765432@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u14725836",
                FirstName = "Simon",
                LastName = "Claw",
                Email = "u14725836@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u24925874",
                FirstName = "Marvin",
                LastName = "Beak",
                Email = "u24925874@tuks.co.za",

            },

        };


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            if(ModelState.IsValid)
            {
                people.Add(person);
                return RedirectToAction("ListPeople");

            }
            return View(person);
        }

        public ActionResult ListPeople()
        {
           

            return View(people);

        }
    }
}