using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public Section Section { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsNew { get; set; }
        public string Notes { get; set; }
        public decimal Price { get; set; }
        public int SectionId { get; set; }

    }
}
