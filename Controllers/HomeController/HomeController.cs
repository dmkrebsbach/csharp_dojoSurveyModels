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

        [HttpPost("result")] //Post Method from the Form
        public IActionResult Results(Survey newSurvey)
        {
            // This recieves a POST from the HTML Form, and grabs the "Survey" class and makes a new instance of the class.
            return View("Results", newSurvey); // returns the information mapped from the class and form
        }
    }
}
