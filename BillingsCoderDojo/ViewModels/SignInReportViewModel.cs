using BillingsCoderDojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingsCoderDojo.ViewModels
{
    public class SignInReportViewModel
    {
        

        public string Username { get; set; }
        public DateTime SignInTime { get; set; }

        public SignInReportViewModel()
        {
            
        }
    }
}