using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrudAdo.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string mobile { get; set; }

    }
}