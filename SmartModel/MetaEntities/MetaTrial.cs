using System;

namespace SmartModel.MetaEntities
{
    public class MetaTrial
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string StudyType { get; set; }

        public string InterventionType { get; set; }
        public int Phase { get; set; }
    }
}
