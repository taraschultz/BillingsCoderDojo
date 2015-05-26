using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillingsCoderDojo.Models;

namespace BillingsCoderDojo.ViewModels
{
    public class SignInViewModel
    {
        public string Username { get; set; }
        public DateTime LogTime { get; set; }

        public SignInViewModel()
        {

        }
        public SignInViewModel( string username )
        {
            Username = username;
            LogTime = DateTime.Now;
        }
    }
}