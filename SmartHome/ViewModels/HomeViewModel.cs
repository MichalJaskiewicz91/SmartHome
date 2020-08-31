using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHome.Models;

namespace SmartHome.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Device> NewDevice { get; set; }
    }
}
