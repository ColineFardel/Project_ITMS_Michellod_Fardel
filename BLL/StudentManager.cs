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
    public class StudentManager : IStudentManager
    {
        public StudentDB StudentDBObject { get; }

        public StudentManager() 
        {
            StudentDBObject = new StudentDB();
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

        public string ShowBalance(string username)
        {
            return StudentDBObject.ShowBalance(username);
        }

        public string ShowBalance(int id)
        {
            return StudentDBObject.ShowBalance(id);
        }
    }
}
