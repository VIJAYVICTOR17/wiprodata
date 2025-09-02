using System.ComponentModel.DataAnnotations;

namespace SmartHomeDbProject.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public int SensorId { get; set; } 
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
    }
}
