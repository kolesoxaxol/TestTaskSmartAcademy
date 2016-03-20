using SmartModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartModel.ViewModel
{
    public class TrialModel
    {
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "min - 3 , max - 20 symbols")]
        public string Status { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "min - 3 , max - 20 symbols")]
        public string StudyType { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "min - 3 , max - 20 symbols")]
        public string InterventionType { get; set; }

        public int Phase { get; set; }
        public bool IsDeleted { get; set; }
     }
}
