using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Models
{
    public class MyOperatingSystem
    {
        public MyOperatingSystem()
        {
            Phones = new HashSet<MobilePhone>();
        }
        public int MyOperatingSystemId { get; set; }
        public string OperatingSystemName { get; set; }
        public ICollection<MobilePhone> Phones { get; set; }
    }
}
