using SmartModel.MetaEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartModel.Entities
{
    [MetadataType(typeof(MetaTrial))]
    public class Trial : IGenericModel
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string StudyType { get; set; }

        public string InterventionType { get; set; }
        public int Phase { get; set; }
        public bool IsDeleted { get; set; }
    }
}
