using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAPI.Models
{
    public class Person
    {
        

        public int id { get; set; } = 0;
        public String firstName { get; set; } = "";
        public String lastName { get; set; } = "";
    }
}