using SmartModel.Entities;
using System.Collections.Generic;


namespace SmartBusinessLogic.Services
{
    public interface ITrialService
    {
       
        Trial GetById(int id);

        void New(Trial trial);

        int GetTrialsCount();

        IEnumerable<Trial> Get();

        void Update(Trial game);

        bool Delete(Trial trial);
    }
}
