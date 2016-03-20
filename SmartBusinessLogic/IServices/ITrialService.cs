using SmartModel.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartBusinessLogic.Services
{
    public interface ITrialService
    {
       
        Task<Trial> GetById(int? id);

        void New(Trial trial);

        Task<IEnumerable<Trial>> Get();

        bool Update(Trial trial);

        bool Delete(Trial trial);

        void Dispose();
    }
}
