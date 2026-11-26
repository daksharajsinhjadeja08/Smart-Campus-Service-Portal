using System.ComponentModel.DataAnnotations;

namespace SmartCampusPortal.Models
{
    public class ServiceRequest
    {
        [Key]
        public int RequestId { get; set; }

        public int StudentId { get; set; }

        public int ServiceId { get; set; }

        public string RequestDescription { get; set; }

        public string Status { get; set; } = "Pending";
    }
}