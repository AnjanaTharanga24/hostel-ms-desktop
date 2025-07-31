using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HMS.Models;
using MySql.Data.MySqlClient;

namespace HMS.Data
{
    public class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository()
        {
            // Update this connection string with your MySQL credentials
            _connectionString = "Server=localhost;Database=hms_db;Uid=root;Pwd=1234;";
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT StudentID, StudentName, DateOfBirth, RoomNo, CreatedDate 
                             FROM Students 
                             ORDER BY StudentName";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            StudentName = reader["StudentName"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            RoomNo = reader["RoomNo"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        });
                    }
                }
            }

            return students;
        }

        public List<Student> SearchStudents(string searchTerm)
        {
            var students = new List<Student>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT StudentID, StudentName, DateOfBirth, RoomNo, CreatedDate 
                             FROM Students 
                             WHERE StudentName LIKE @searchTerm OR RoomNo LIKE @searchTerm
                             ORDER BY StudentName";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentName = reader["StudentName"].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                                RoomNo = reader["RoomNo"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                            });
                        }
                    }
                }
            }

            return students;
        }

        public bool InsertStudent(Student student)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"INSERT INTO Students (StudentName, DateOfBirth, RoomNo, CreatedDate) 
                             VALUES (@StudentName, @DateOfBirth, @RoomNo, @CreatedDate)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", student.StudentName);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@RoomNo", student.RoomNo);
                    command.Parameters.AddWithValue("@CreatedDate", student.CreatedDate);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStudent(Student student)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"UPDATE Students 
                             SET StudentName = @StudentName, DateOfBirth = @DateOfBirth, RoomNo = @RoomNo 
                             WHERE StudentID = @StudentID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", student.StudentID);
                    command.Parameters.AddWithValue("@StudentName", student.StudentName);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@RoomNo", student.RoomNo);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteStudent(int studentId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Student GetStudentById(int studentId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT StudentID, StudentName, DateOfBirth, RoomNo, CreatedDate 
                             FROM Students 
                             WHERE StudentID = @StudentID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentName = reader["StudentName"].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                                RoomNo = reader["RoomNo"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    return connection.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}