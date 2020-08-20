using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_K3.Entity
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }

        public bool IsNewStudent()
        {
            return CreatedAt >= DateTime.Now.AddMonths(-2);
        }

        public bool IsDeactive()
        {
            return Status == StudentStatus.DEACTIVE;
        }

        public override string ToString()
        {
            return $"Fullname {FullName}, rollnumber {RollNumber}";
        }
    }
    public enum StudentStatus
    {
        ACTIVE = 1,
        DEACTIVE = 0
    }
}
