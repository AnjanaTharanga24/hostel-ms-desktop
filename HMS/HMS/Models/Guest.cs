using System;

namespace HMS.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string GuestName { get; set; }
        public string PhoneNo { get; set; }
        public string RoomNo { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guest()
        {
            CreatedDate = DateTime.Now;
        }
    }
}