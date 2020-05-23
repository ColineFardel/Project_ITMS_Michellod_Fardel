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
    [ServiceContractAttribute]
    public interface IStudent
    {

        [OperationContractAttribute(Name ="AddMoneyUID")]
        int AddMoney(int id, double money);

        [OperationContractAttribute(Name ="AddMoneyUsername")]
        int AddMoney(string username, double money);

        [OperationContractAttribute(Name ="AddMoneyStudent")]
        int AddMoney(Student student, double money);

        [OperationContractAttribute]
        List<Student> GetAllStudents();

        [OperationContractAttribute]
        Student GetStudentByUID(int id);

        [OperationContractAttribute]
        Student GetStudentByUsername(string username);

        [OperationContractAttribute(Name ="ShowBalanceID")]
        string ShowBalance(int id);

        [OperationContractAttribute(Name ="ShowBalanceStudent")]
        string ShowBalance(Student student);

        [OperationContractAttribute(Name ="ShowBalanceUsername")]
        string ShowBalance(string username);
    }

}
