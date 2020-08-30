using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class MockDeviceRepository :IDeviceRepository
    {
        //private readonly IDeviceRepository _deviceRepository = new MockDeviceRepository();
        // Hardcoded list of devices
        public IEnumerable<Device> AllDevices =>
            new List<Device>
            {
                new Device { DeviceId = 1, Name="Lighting source", ShortDescription = "Lighting source for instance - LED"},
                new Device { DeviceId = 2, Name="Pump", ShortDescription = "Pump that allows water flow"},
                new Device { DeviceId = 3, Name="Roller blind", ShortDescription = "Roller blind that allows window covering"},
            };

        
        public Device GetDeviceId(int deviceId)
        {
            return AllDevices.FirstOrDefault(p => p.DeviceId == deviceId);
        }
    }
}
