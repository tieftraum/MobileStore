using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Resources
{
    public class MobilePhoneFilterSearchResource
    {
        public string Name { get; set; }
        public int? ManufacturerId { get; set; }
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
    }
}
