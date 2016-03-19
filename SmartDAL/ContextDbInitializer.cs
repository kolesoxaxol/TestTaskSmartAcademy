using SmartModel.Entities;
using System;
using System.Data.Entity;

namespace SmartDAL
{
    public class SmartContextDbInitializer : DropCreateDatabaseAlways<SmartContext>
    {
        protected override void Seed(SmartContext context)
        {


            #region Trial
            Trial trial = new Trial { EndDate = new DateTime(2016, 7, 23), InterventionType = "test1", IsDeleted = false, Phase = 1, Status = "Success", StudyType = "test1", StartDate = DateTime.Now };
            context.Trials.Add(trial);
            trial = new Trial { EndDate = new DateTime(2016, 8, 11), InterventionType = "test2", IsDeleted = false, Phase = 1, Status = "Success", StudyType = "test2", StartDate = DateTime.Now };
            context.Trials.Add(trial);
            trial = new Trial { EndDate = new DateTime(2016,2, 24), InterventionType = "test3", IsDeleted = false, Phase = 1, Status = "Success", StudyType = "test3", StartDate = DateTime.Now };
            context.Trials.Add(trial);
            context.SaveChanges();
           
            #endregion

        }
    }
}
