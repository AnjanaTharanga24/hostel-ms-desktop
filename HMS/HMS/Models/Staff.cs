using System;

namespace HMS.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }

        public Staff()
        {
            CreatedDate = DateTime.Now;
        }
    }
}