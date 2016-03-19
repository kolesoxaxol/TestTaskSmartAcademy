using SmartModel.MetaEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartModel.Entities
{
    [MetadataType(typeof(MetaTrial))]
    public class Trial : IGenericModel
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "min - 3 , max - 20 symbols")]
        public string StudyType { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "min - 3 , max - 20 symbols")]
        public string InterventionType { get; set; }
        [Required]
        public int Phase { get; set; }
    }
}
