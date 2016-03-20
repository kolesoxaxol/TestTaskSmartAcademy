using System;
using System.ComponentModel.DataAnnotations;

namespace SmartModel.MetaEntities
{
    public class MetaTrial
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

       
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string StudyType { get; set; }

        public string InterventionType { get; set; }

        [Required]
        public int Phase { get; set; }

        public bool IsDeleted { get; set; }
    }
}
