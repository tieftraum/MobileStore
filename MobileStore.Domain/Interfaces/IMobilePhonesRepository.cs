using MobileStore.Domain.Models;
using MobileStore.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Domain.Interfaces
{
    public interface IMobilePhonesRepository
    {
        Task<IEnumerable<MobilePhone>> GetMobilePhones();
        Task<IEnumerable<MobilePhone>> GetMobilePhonesFromSearchFilter(MobilePhoneFilterSearchResource resource);
        Task<MobilePhone> GetMobileAsync(int id);
    }
}
