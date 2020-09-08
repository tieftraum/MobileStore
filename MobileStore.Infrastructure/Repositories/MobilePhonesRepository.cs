using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MobileStore.Domain.Interfaces;
using MobileStore.Domain.Models;
using MobileStore.Domain.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Infrastructure.Repositories
{
    public class MobilePhonesRepository : IMobilePhonesRepository
    {
        private readonly AppDbContext _context;
        public MobilePhonesRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<MobilePhone> GetMobileAsync(int id)
        {
            var mobilePhone = await _context.MobilePhones.FirstOrDefaultAsync(e => e.MobilePhoneId == id);

            return mobilePhone;
        }
        public async Task<IEnumerable<MobilePhone>> GetMobilePhones()
        {
            return await _context.MobilePhones.ToListAsync();
        }
        public async Task<IEnumerable<MobilePhone>> GetMobilePhonesFromSearchFilter(MobilePhoneFilterSearchResource resource)
        {
            var result = (from mp in _context.MobilePhones
                          join m in _context.Manufacturers on mp.ManufacturerId equals m.ManufacturerId
                          where (
                                  ((!string.IsNullOrEmpty(resource.Name) && mp.Name.Contains(resource.Name)) || string.IsNullOrEmpty(resource.Name))
                                && ((resource.ManufacturerId != null && mp.ManufacturerId == resource.ManufacturerId) || resource.ManufacturerId == null)
                                && (mp.Price >= resource.PriceFrom)
                                && ((resource.PriceTo != 0 && mp.Price <= resource.PriceTo) || resource.PriceTo == 0)
                                )
                          select new MobilePhone { Name = mp.Name, Price = mp.Price , Manufacturer = mp.Manufacturer, 
                          Memory = mp.Memory, PicturesAndVideosUrlOrPath = mp.PicturesAndVideosUrlOrPath, ScreenSizeAndResolution = mp.ScreenSizeAndResolution, Size = mp.Size, Weight = mp.Weight , CPU =  mp.CPU, OperatingSystem = mp.OperatingSystem
                           });

            return await result.ToListAsync();
        }
    }
}
