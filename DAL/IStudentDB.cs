using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface IStudentDB
    {
        List<Student> GetAllStudents();

        Student GetStudentByUID(int id);
        Student GetStudentByUsername(string username);

        int AddMoney(Student student, double Money);
        int AddMoney(int id, double Money);
        int AddMoney(string username, double Money);
        //jme rappelle plus si faut mettre un truc pour print ?
        //int Print(Student student, int copies);
    }
}
