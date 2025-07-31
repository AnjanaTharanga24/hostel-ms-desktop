using System;

namespace HMS.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RoomNo { get; set; }
        public DateTime CreatedDate { get; set; }

        public Student()
        {
            CreatedDate = DateTime.Now;
        }
    }
}