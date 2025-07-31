using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using HMS.Models;

namespace HMS.Data
{
    public class StaffRepository
    {
        private readonly string _connectionString;

        public StaffRepository()
        {
            // Update this connection string with your MySQL credentials
            _connectionString = "Server=localhost;Database=hms_db;Uid=root;Pwd=1234;";
        }

        public List<Staff> GetAllStaff()
        {
            var staffList = new List<Staff>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT StaffID, StaffName, PhoneNo, Address, CreatedDate 
                             FROM Staff 
                             ORDER BY StaffName";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            StaffID = Convert.ToInt32(reader["StaffID"]),
                            StaffName = reader["StaffName"].ToString(),
                            PhoneNo = reader["PhoneNo"].ToString(),
                            Address = reader["Address"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        });
                    }
                }
            }

            return staffList;
        }

        public List<Staff> SearchStaff(string searchTerm)
        {
            var staffList = new List<Staff>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT StaffID, StaffName, PhoneNo, Address, CreatedDate 
                             FROM Staff 
                             WHERE StaffName LIKE @searchTerm 
                             OR PhoneNo LIKE @searchTerm 
                             OR Address LIKE @searchTerm
                             ORDER BY StaffName";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffList.Add(new Staff
                            {
                                StaffID = Convert.ToInt32(reader["StaffID"]),
                                StaffName = reader["StaffName"].ToString(),
                                PhoneNo = reader["PhoneNo"].ToString(),
                                Address = reader["Address"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                            });
                        }
                    }
                }
            }

            return staffList;
        }

        public bool InsertStaff(Staff staff)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"INSERT INTO Staff (StaffName, PhoneNo, Address, CreatedDate) 
                             VALUES (@StaffName, @PhoneNo, @Address, @CreatedDate)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffName", staff.StaffName);
                    command.Parameters.AddWithValue("@PhoneNo", staff.PhoneNo);
                    command.Parameters.AddWithValue("@Address", staff.Address);
                    command.Parameters.AddWithValue("@CreatedDate", staff.CreatedDate);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStaff(Staff staff)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"UPDATE Staff 
                             SET StaffName = @StaffName, PhoneNo = @PhoneNo, Address = @Address 
                             WHERE StaffID = @StaffID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staff.StaffID);
                    command.Parameters.AddWithValue("@StaffName", staff.StaffName);
                    command.Parameters.AddWithValue("@PhoneNo", staff.PhoneNo);
                    command.Parameters.AddWithValue("@Address", staff.Address);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteStaff(int staffId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Staff WHERE StaffID = @StaffID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staffId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Staff GetStaffById(int staffId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT StaffID, StaffName, PhoneNo, Address, CreatedDate 
                             FROM Staff 
                             WHERE StaffID = @StaffID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staffId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Staff
                            {
                                StaffID = Convert.ToInt32(reader["StaffID"]),
                                StaffName = reader["StaffName"].ToString(),
                                PhoneNo = reader["PhoneNo"].ToString(),
                                Address = reader["Address"].ToString(),
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

        public bool IsPhoneNumberExists(string phoneNo, int? excludeStaffId = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Staff WHERE PhoneNo = @PhoneNo";

                if (excludeStaffId.HasValue)
                {
                    query += " AND StaffID != @ExcludeStaffID";
                }

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    if (excludeStaffId.HasValue)
                    {
                        command.Parameters.AddWithValue("@ExcludeStaffID", excludeStaffId.Value);
                    }

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Phone number exists if count is greater than 0
                }
            }
        }
    }
}