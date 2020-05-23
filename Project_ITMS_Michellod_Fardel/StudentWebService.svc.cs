using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using BLL;
using DTO;

namespace Project_ITMS_Michellod_Fardel
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class StudentWebService : IStudent
    {
        public StudentDB StudentDBObject { get; }

        public StudentWebService()
        {
            StudentDBObject = new StudentDB();
        }

        int IStudent.AddMoney(int id, double money)
        {
            return StudentDBObject.AddMoney(id, money);
        }

        int IStudent.AddMoney(string username, double money)
        {
            return StudentDBObject.AddMoney(username, money);
        }

        int IStudent.AddMoney(Student student, double money)
        {
            return StudentDBObject.AddMoney(student, money);
        }

        Student IStudent.GetStudentByUsername(string username)
        {
            return StudentDBObject.GetStudentByUsername(username);
        }

        Student IStudent.GetStudentByUID(int id)
        {
            return StudentDBObject.GetStudentByUID(id);
        }

        List<Student> IStudent.GetAllStudents()
        {
            return StudentDBObject.GetAllStudents();
        }

        string IStudent.ShowBalance(int id)
        {
            return StudentDBObject.ShowBalance(id);
        }

        string IStudent.ShowBalance(Student student)
        {
            return StudentDBObject.ShowBalance(student);
        }

        string IStudent.ShowBalance(string username)
        {
            return StudentDBObject.ShowBalance(username);
        }
    }
}
