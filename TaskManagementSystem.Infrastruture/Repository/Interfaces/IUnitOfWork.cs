using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepo<T> GetRepository<T>() where T : class;
        void SaveChanges();
    }

}
