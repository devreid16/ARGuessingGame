using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArGuessingGame.Models
{

    public class AngieGame
    {

        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage ="You Must Enter Your Name")]
        [MinLength(2,ErrorMessage ="Name is too short.")]
        [MaxLength(20,ErrorMessage ="Name is too long.")]
        

        public string PlayerName { get; set; }


        [Display(Name = "Enter Your Number (Between 1 and 50)")]
        [Required(ErrorMessage ="You Must Enter a Guess")]
        [Range(1, 50, ErrorMessage = "Number Must be between 1 and 50.")]

        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }    
}