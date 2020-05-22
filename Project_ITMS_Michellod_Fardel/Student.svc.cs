using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;

namespace Project_ITMS_Michellod_Fardel
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Student : IStudent
    {

        int IStudent.AddMoney(int id, double money)
        {
            return StudentDB.AddMoney(id, money);
        }

        int IStudent.AddMoney(string username, double money)
        {
            return StudentDB.AddMoney(username, money);
        }
        
        int IStudent.AddMoney(Student student, double money)
        {
            return StudentDB.AddMoney(student, money);
        }
        Student IStudent.GetStudentByUsername(string username)
        {
            return StudentDB.GetStudentByUsername(username);
        }
        Student IStudent.GetStudentByUID(int id)
        {
            return StudentDB.GetStudentByUID(id);
        }
        List<Student> IStudent.GetAllStudents()
        {
            return StudentDB.GetAllStudents();
        }
    }
}
