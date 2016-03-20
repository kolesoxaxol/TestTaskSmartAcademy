using SmartModel.Entities;
using SmartModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartApplication.Controllers
{
    public static class ExtensionsEntitiesMethod
    {
        public static TrialModel ToModel(this Trial obj)
        {
            TrialModel trial = new TrialModel();
            trial.EndDate = obj.EndDate;
            trial.InterventionType = obj.InterventionType;
            trial.Phase = obj.Phase;
            trial.StartDate = obj.StartDate;
            trial.Status = obj.Status;
            trial.Id = obj.Id;
            trial.IsDeleted = obj.IsDeleted;
            trial.StudyType = obj.StudyType;
            return trial;
        }

        public static Trial ToEntity(this TrialModel obj)
        {
            Trial trial = new Trial();
            trial.EndDate = obj.EndDate;
            trial.InterventionType = obj.InterventionType;
            trial.Phase = obj.Phase;
            trial.StartDate = obj.StartDate;
            trial.Status = obj.Status;
            trial.Id = obj.Id;
            trial.IsDeleted = obj.IsDeleted;
            trial.StudyType = obj.StudyType;
            return trial;
        }
    }
}
