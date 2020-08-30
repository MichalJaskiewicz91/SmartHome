using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHome.Models;

namespace SmartHome.ViewModels
{
    public class DevicesListViewModel
    {
        public IEnumerable<Device> Devices { get; set; }
        public string CurrentSection { get; set; }
    }
}
