using System;
using System.Collections.Generic;
using SmartModel.Entities;
using SmartDAL;
using System.Linq;

namespace SmartBusinessLogic.Services
{
    class TrialService : ITrialService
    {
        private readonly IGenericRepository<Trial> _repository;
     
        public TrialService(IGenericRepository<Trial> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Trial> Get()
        {
            try
            {
                return _repository.Get();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Trial GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
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
        public int GetTrialsCount()
        {
            try
            {
                return _repository.Get().ToList().Count;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Update(Trial game)
        {
            try
            {
                _repository.Update(game);
                _repository.Save();
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

    }
}
