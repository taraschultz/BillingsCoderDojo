using BillingsCoderDojo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillingsCoderDojo.ViewModels
{
    public class SignInReportViewModel
    {
        

        public string Username { get; set; }

        [Display(Name = "Sign In Time")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime SignInTime { get; set; }

        public SignInReportViewModel()
        {
            
        }
    }
}