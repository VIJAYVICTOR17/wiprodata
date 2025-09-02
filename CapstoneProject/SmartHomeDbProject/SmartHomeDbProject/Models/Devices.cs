using System.ComponentModel.DataAnnotations;

namespace SmartHomeDbProject.Models
{
    public class Devices
    {
        [Key]
        public int DeviceId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceType { get; set; }
        public string? Location { get; set; }
        public int UserId { get; set; }
    }
}
