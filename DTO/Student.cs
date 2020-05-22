using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        public int UID { get; set; }

        public string Username { get; set; }

        public double Money { get; set; }

        public string toString()
        {
            return UID + " " + Username + " Balance : " + Money;
        }
    }

    
}
