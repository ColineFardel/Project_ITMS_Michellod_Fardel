using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.Extensions.Configuration;

namespace BLL
{
    public class StudentManager
    {
        public StudentDB StudentDBObject { get; }

        public StudentManager(IConfiguration configuration) 
        {
            StudentDBObject = new StudentDB(configuration);
        }

        public int AddMoney(int id, double money) 
        {
            return StudentDBObject.AddMoney(id,money);
        }
        public int AddMoney(string username, double money)
        {
            return StudentDBObject.AddMoney(username, money);
        }
        public List<Student> GetStudents()
        {
            return StudentDBObject.GetAllStudents();
        }
    }
}
