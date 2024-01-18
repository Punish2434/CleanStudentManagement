using System;
using CleanStudentManagement.Data.Repository;

namespace CleanStudentManagement.Data.UnitOfWork
{
	public interface IUnitOfWork
	{
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void Save();
    }
}

