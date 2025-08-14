using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LmsProject.Models
{
    public class Employee
    {
        [Key]
        [Column("EmpId")]
        public int EmpId { get; set; }
        [Column("EmployName")]
        public string? EmployName { get; set; }

        [Column("MgrId")]
        public int? MgrId { get; set; }

        [Column("LeaveAvail")]
        public int LeaveAvail { get; set; }

        [Column("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("Mobile")]
        public string? Mobile { get; set; }
    }
}
