using System.ComponentModel.DataAnnotations;

namespace SmartCampusPortal.Models
{
    public class CampusService
    {
        [Key]
        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }
    }
}