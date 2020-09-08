using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Models
{
    public class CPU
    {
        public CPU()
        {
            Phones = new HashSet<MobilePhone>();
        }
        public int CPUId { get; set; }
        public string CPUName { get; set; }
        public ICollection<MobilePhone> Phones { get; set; }
    }
}
