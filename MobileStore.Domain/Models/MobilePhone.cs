using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Models
{
    public class MobilePhone
    {
        public int MobilePhoneId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string ScreenSizeAndResolution { get; set; }
        public string Memory { get; set; }
        public string PicturesAndVideosUrlOrPath { get; set; }
        public decimal Price { get; set; }
        public int CPUId { get; set; }
        public CPU CPU { get; set; }
        public int MyOperatingSystemId { get; set; }
        public MyOperatingSystem OperatingSystem { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
