using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> AllPies { get; }
        Device GetDeviceId(int deviceId);
    }
}
