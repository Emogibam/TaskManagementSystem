using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Infrastruture.Context;
using TaskManagementSystem.Infrastruture.Repository.Interfaces;

namespace TaskManagementSystem.Infrastruture.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _repositories = new Dictionary<Type, object>();
        }

        public IGenericRepo<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return _repositories[typeof(T)] as IGenericRepo<T>;
            }

            var repository = new GenericRepo<T>(_appDbContext);
            _repositories.Add(typeof(T), repository);
            return repository;
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}
