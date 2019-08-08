using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dojoSurveyModel.Models{
    public class Survey
    {
        [Required(ErrorMessage = "Please enter your First name")]
        [MinLength(4, ErrorMessage = "First Name must be at least 4 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select a Dojo Location")]
        public string Dojo { get; set; }

        [Required(ErrorMessage = "Please Enter Your Favorite Language")]
        public string Language{ get; set; }

        [MaxLength(20, ErrorMessage = "Keep your comment to 20 Characters or Less")]
        public string Comment{ get; set; }
        
    }
}
