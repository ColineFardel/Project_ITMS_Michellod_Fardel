using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public interface IStudentManager
    {
        int AddMoney(int id, double money);
        int AddMoney(string username, double money);
        string ShowBalance(string username);
        string ShowBalance(int id);
        List<Student> GetStudents();
    }
}
