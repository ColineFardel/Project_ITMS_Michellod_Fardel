using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class StudentDB
    {

        //Iconfiguration ???

        public StudentDB()
        { 
            
        }


        public Student GetStudentByUID(int id) 
        {
            Student student = null;
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Hotels WHERE UID = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            student = new Student();

                            student.UID = (int)dr["UID"];
                            student.Username = (string)dr["Username"];
                            student.Money = (double)dr["Money"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return student;
        }

        public int AddMoney(Student student)
        {
            int result = 0;
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Student SET Username=@Username, Money=@Money WHERE UID=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", student.UID);
                    cmd.Parameters.AddWithValue("@Username", student.Username);
                    //a droite c ce que on veut changer ?? Si oui ajouter un param money
                    cmd.Parameters.AddWithValue("@Money", student.Money);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int AddMoneyByUID(int id)
        {
            return AddMoney(GetStudentByUID(id));
        }
    }
}
