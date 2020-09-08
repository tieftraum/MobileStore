using MobileStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Resources
{
    public class MobilePhoneResource
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string ScreenSizeAndResolution { get; set; }
        public string Memory { get; set; }
        public string PicturesAndVideosUrlOrPath { get; set; }
        public decimal Price { get; set; }
        public string CPUName { get; set; }
        public string OperatingSystemName { get; set; }
        public string ManufacturerName { get; set; }
    }
}
