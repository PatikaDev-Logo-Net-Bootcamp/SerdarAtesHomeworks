using System;


namespace ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts
{
    public interface IUnitOfWork : IDisposable
    {
        AppDbContext Context { get; }
        void Commit();
    }
}
