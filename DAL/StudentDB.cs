using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class StudentDB : IStudentDB
    {
        public string connectionString = null;

        public StudentDB() {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        /**
         * This method is used to get all students from the database
         */
        public List<Student> GetAllStudents()
        {
            List<Student> students = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Students";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (students == null)
                                students = new List<Student>();

                            Student student = new Student();

                            student.UID = (int)dr["UID"];
                            student.Username = (string)dr["Username"];
                            student.Money = (double)dr["Money"];

                            students.Add(student);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return students;
        }

        /**
         * This method is used to get a Student with its id/UID
         */
        public Student GetStudentByUID(int id) 
        {
            Student student = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Students WHERE UID = @id";
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

        /**
         * This method is used to get a Student with its username
         */
        public Student GetStudentByUsername(string username)
        {
            Student student = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Students WHERE Username = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

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

        /**
         * This methode is used to add money to a student
         */
        public int AddMoney(Student student, double Money)
        {
            int result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Students SET Username=@Username, Money=@Money WHERE UID=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", student.UID);
                    cmd.Parameters.AddWithValue("@Username", student.Username);
                    //a droite c ce que on veut changer ?? Si oui ajouter un param money
                    cmd.Parameters.AddWithValue("@Money", Money);

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
        /**
         * This method is used to add money to a student using its id
         */
        public int AddMoney(int id, double Money)
        {
            return AddMoney(GetStudentByUID(id),Money);
        }

        /**
         * This method is used to add money to a student using its username
         */
        public int AddMoney(string username, double Money)
        {
            return AddMoney(GetStudentByUsername(username), Money);
        }

        /**
         * This method is used to show the balance of a student
         */
        public string ShowBalance(Student student) 
        {
            return "Balance of " + student.Username + " : " + student.Money;
        
        }
        /**
         * This method is used to show balance of a student using its id
         */
        public string ShowBalance(int id)
        {
            return ShowBalance(GetStudentByUID(id));
        }

        /**
         * This method is used to show balance of a student using its username
         */
        public string ShowBalance(string username)
        {
            return ShowBalance(GetStudentByUsername(username));
        }


    }
}
