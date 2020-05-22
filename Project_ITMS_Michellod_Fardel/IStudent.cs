using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL;
using DTO;


namespace Project_ITMS_Michellod_Fardel
{
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        int AddMoney(int id, double money);

        [OperationContract]
        int AddMoney(string username, double money);

        [OperationContract]
        int AddMoney(Student student, double money);

        [OperationContract]
        List<Student> GetAllStudents();

        [OperationContract]
        Student GetStudentByUID(int id);

        [OperationContract]
        Student GetStudentByUsername(string username);

        [OperationContract]
        string ShowBalance(int id);

        [OperationContract]
        string ShowBalance(Student student);

        [OperationContract]
        string ShowBalance(string username);
    }

}
