using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingsCoderDojo.Models
{
    [Table("SignIn")]
    public class SignInModels
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime LogTime { get; set; }
    }
}