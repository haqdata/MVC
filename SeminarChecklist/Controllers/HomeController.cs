﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeminarChecklist.Models;

namespace SeminarChecklist.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
          //public string Index()
       public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
           // return "Welcome to the Seminar";
        }

       [HttpGet]
       public ViewResult RsvpForm()
       {
           return View();
       }

       [HttpPost]
       public ViewResult RsvpForm(GuestResponse guestResponse)
       {
           if (ModelState.IsValid)
           {
               // TODO: Email response to the party organizer
               return View("Thanks", guestResponse);
           }
           else
           {
               // there is a validation error
               return View();
           }
       }
    }
}