using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project_ITMS_Michellod_Fardel
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int AddMoney(int id, double money);

        [OperationContract]
        int AddMoney(string username, double money);

        [OperationContract]
        List<Student> GetStudents();
    }

}
