using System.ComponentModel.DataAnnotations;

namespace SmartHomeDbProject.Models
{
    public class ControlLog
    {
        [Key]
        public int LogId { get; set; }
        public int SensorId { get; set; }
        public string? Action {  get; set; }
        public DateTime ActionTime { get; set; }
    }
}
