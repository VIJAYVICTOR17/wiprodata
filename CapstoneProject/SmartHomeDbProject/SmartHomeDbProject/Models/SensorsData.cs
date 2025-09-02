using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeDbProject.Models
{
    public class SensorsData
    {
        [Key]
        public int SensorId { get; set; }
        public int DeviceId { get; set; }
        public string? SensorType { get; set; }
        public string? SensorStatus { get; set; }
        public DateTime ReadingTime { get; set; }  
    }
}
