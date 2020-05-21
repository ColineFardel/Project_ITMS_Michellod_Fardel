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
        List<Student> GetStudents();
    }
}
