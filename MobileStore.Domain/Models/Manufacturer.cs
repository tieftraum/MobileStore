using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            Phones = new HashSet<MobilePhone>();
        }
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public ICollection<MobilePhone> Phones { get; set; }
    }
}
