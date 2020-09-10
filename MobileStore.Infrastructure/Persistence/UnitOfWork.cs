using MobileStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IMobilePhonesRepository Phones { get; private set; }

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
