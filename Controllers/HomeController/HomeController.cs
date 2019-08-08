using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyModel.Models;

namespace dojoSurveyModel
{
    public class HomeController: Controller
    {
        [HttpGet("")] //This renders the Main Page        
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("createSurvey")]
        public IActionResult Create(Survey newSurvey)
        {
            Console.Write("Is This Getting Here?");
            if(ModelState.IsValid)
            {
                Console.Write("###########It's Valid?#########");
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Success", newSurvey);
            }
            else
            {
                Console.Write("##########It's Not Valid?#########");
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }


        [HttpGet("Results")] //Post Method from the Form
        public IActionResult Success(Survey newSurvey)
        {
            // This recieves a POST from the HTML Form, and grabs the "Survey" class and makes a new instance of the class.
            return View("Results", newSurvey); // returns the information mapped from the class and form
        }
    }
}
