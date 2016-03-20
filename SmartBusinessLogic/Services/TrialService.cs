using System;
using System.Collections.Generic;
using SmartModel.Entities;
using SmartDAL;
using System.Threading.Tasks;

namespace SmartBusinessLogic.Services
{
    public class TrialService : ITrialService
    {
        private readonly IGenericRepository<Trial> _repository;
     
        public TrialService(IGenericRepository<Trial> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Trial>> Get()
        {
            try
            {
                return await _repository.Get();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<Trial> GetById(int? id)
        {
            try
            {
                return await _repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool Delete(Trial trial)
        {
            try
            {
                if (trial == null)
                {
                    throw new ArgumentException("trial is null");
                }

                {
                    trial.IsDeleted = true;
                    _repository.Update(trial);
                }

                _repository.Save();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool Update(Trial trial)
        {
            try
            {
                _repository.Update(trial);
                _repository.Save();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public void New(Trial trial)
        {
            try
            {
                if (trial == null)
                {
                   throw new ArgumentNullException("trial");
                }
               
               _repository.Insert(trial);
               _repository.Save();
               
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
