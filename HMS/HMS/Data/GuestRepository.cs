using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using HMS.Models;

namespace HMS.Data
{
    public class GuestRepository
    {
        private readonly string _connectionString;

        public GuestRepository()
        {
            // Update this connection string with your MySQL credentials
            _connectionString = "Server=localhost;Database=hms_db;Uid=root;Pwd=1234;";
        }

        public List<Guest> GetAllGuests()
        {
            var guests = new List<Guest>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT GuestID, GuestName, PhoneNo, RoomNo, CreatedDate 
                             FROM Guests 
                             ORDER BY GuestName";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guests.Add(new Guest
                        {
                            GuestID = Convert.ToInt32(reader["GuestID"]),
                            GuestName = reader["GuestName"].ToString(),
                            PhoneNo = reader["PhoneNo"].ToString(),
                            RoomNo = reader["RoomNo"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        });
                    }
                }
            }

            return guests;
        }

        public List<Guest> SearchGuests(string searchTerm)
        {
            var guests = new List<Guest>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT GuestID, GuestName, PhoneNo, RoomNo, CreatedDate 
                             FROM Guests 
                             WHERE GuestName LIKE @searchTerm 
                             OR PhoneNo LIKE @searchTerm 
                             OR RoomNo LIKE @searchTerm
                             ORDER BY GuestName";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(new Guest
                            {
                                GuestID = Convert.ToInt32(reader["GuestID"]),
                                GuestName = reader["GuestName"].ToString(),
                                PhoneNo = reader["PhoneNo"].ToString(),
                                RoomNo = reader["RoomNo"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                            });
                        }
                    }
                }
            }

            return guests;
        }

        public bool InsertGuest(Guest guest)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"INSERT INTO Guests (GuestName, PhoneNo, RoomNo, CreatedDate) 
                             VALUES (@GuestName, @PhoneNo, @RoomNo, @CreatedDate)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GuestName", guest.GuestName);
                    command.Parameters.AddWithValue("@PhoneNo", guest.PhoneNo);
                    command.Parameters.AddWithValue("@RoomNo", guest.RoomNo);
                    command.Parameters.AddWithValue("@CreatedDate", guest.CreatedDate);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateGuest(Guest guest)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"UPDATE Guests 
                             SET GuestName = @GuestName, PhoneNo = @PhoneNo, RoomNo = @RoomNo 
                             WHERE GuestID = @GuestID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GuestID", guest.GuestID);
                    command.Parameters.AddWithValue("@GuestName", guest.GuestName);
                    command.Parameters.AddWithValue("@PhoneNo", guest.PhoneNo);
                    command.Parameters.AddWithValue("@RoomNo", guest.RoomNo);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteGuest(int guestId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Guests WHERE GuestID = @GuestID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GuestID", guestId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Guest GetGuestById(int guestId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT GuestID, GuestName, PhoneNo, RoomNo, CreatedDate 
                             FROM Guests 
                             WHERE GuestID = @GuestID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GuestID", guestId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Guest
                            {
                                GuestID = Convert.ToInt32(reader["GuestID"]),
                                GuestName = reader["GuestName"].ToString(),
                                PhoneNo = reader["PhoneNo"].ToString(),
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

        public bool IsRoomAvailable(string roomNo, int? excludeGuestId = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Guests WHERE RoomNo = @RoomNo";

                if (excludeGuestId.HasValue)
                {
                    query += " AND GuestID != @ExcludeGuestID";
                }

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNo", roomNo);
                    if (excludeGuestId.HasValue)
                    {
                        command.Parameters.AddWithValue("@ExcludeGuestID", excludeGuestId.Value);
                    }

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0; // Room is available if count is 0
                }
            }
        }
    }
}