using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _75_MVC_Helper.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string NameAndSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
    }
}