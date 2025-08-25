using System.ComponentModel.DataAnnotations;

namespace CarProg.Models
{
    public class Vehicle
    {
        [Key]
        public int vehicleID { get; set; }
        public string? make { get; set; }
        public string? model { get; set; }
        public int year { get; set; }
        public decimal dailyRate { get; set; }
        public string? status { get; set; }
        public int passengerCapacity { get; set; }
        public decimal engineCapacity { get; set; }
        public int customerID  { get; set; }
    }
}
