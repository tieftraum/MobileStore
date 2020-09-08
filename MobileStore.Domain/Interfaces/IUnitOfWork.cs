using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IMobilePhonesRepository Phones { get; }
        int Complete();
    }
}
