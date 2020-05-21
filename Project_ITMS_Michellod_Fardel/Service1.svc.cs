using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project_ITMS_Michellod_Fardel
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {

        int IService1.AddMoney(int id, double money)
        {
            return StudentDBObject.AddMoney(id, money);
        }
        [OperationContract]
        int IService1.AddMoney(string username, double money)
        {
            return StudentDBObject.AddMoney(username, money);
        }
        [OperationContract]
        List<Student> IService1.GetStudents()
        {
            return StudentDBObject.GetAllStudents();
        }
    }
}
