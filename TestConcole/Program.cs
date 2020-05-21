using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;
using Microsoft.Extensions.Configuration;

namespace TestConcole
{
    class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("jsconfig.json", optional: true, reloadOnChange: true)
            .Build();
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager(Configuration);

            Console.WriteLine("Get all Students");
            List<Student> students = studentManager.GetStudents();
            foreach (Student student in students)
            {
                Console.WriteLine(student.toString());
            }

            Console.WriteLine("Add money to one student with its UID");

            Console.WriteLine("Add money to one student with its username");
        }
    }
}
