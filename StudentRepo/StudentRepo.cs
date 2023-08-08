using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary.SrudentModel;
using StudentLibrary.StudentBusiness;
using Dapper;
using System.Data.SqlClient;

namespace StudentLibrary.StudentRepo
{
    
        public class StudentDataRepo
        {
            public readonly string connectionString;



            public StudentDataRepo()
            {
                connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=StudentData;User Id=sa;Password=Anaiyaan@123";
            }

            public void InsertStudentData(StudentDataModel std)
            {

                try
                {
                SqlConnection con = new SqlConnection (connectionString);

                    con.Open();
                    con.Execute($"   exec InsertStudentData '{std.StudentName}', '{std.SubjectName}',{std.SubjectMark}");

                    con.Close();

                }
                catch (SqlException ex)
                {
                    throw;
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            public StudentDataModel liststudentdata(int id)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    var connection = new SqlConnection(connectionString);
                    con.Open();
                    var Student = connection.QueryFirst<StudentDataModel>($"   exec liststudentdata {id} ");
                    con.Close();



                    return Student;


                }

                catch (SqlException er)
                {
                    throw;
                }
                catch (Exception r)
                {
                    throw r;
                }
            }

            public List<StudentDataModel> liststudentdata()
            {
                try
                {
                    List<StudentDataModel> constrain = new List<StudentDataModel>();

                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    constrain = connection.Query<StudentDataModel>(" exec Liststudentdatas ").ToList();
                    connection.Close();

                    return constrain;


                }

                catch (SqlException er)
                {
                    throw;
                }
                catch (Exception r)
                {
                    throw r;
                }
            }

            public void UpdateStudentData(StudentDataModel std)
            {
                try
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                con.Execute($"  exec UpdateStudentData  '{std.StudentName}', '{std.SubjectName}',{std.SubjectMark},{std.StudentID}");
                con.Close();
                }
                catch (SqlException eu)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public void DeleteStudentData(int id)
            {
                try
                {


                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    con.Execute($"  exec DeleteStudentData { id}");

                    con.Close();

                }
                catch (SqlException ed)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

    }

