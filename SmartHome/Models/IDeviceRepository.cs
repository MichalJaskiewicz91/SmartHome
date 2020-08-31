using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public interface IDeviceRepository
    {
        /// <summary>
        /// Get all devices
        /// </summary>
        IEnumerable<Device> AllDevices { get; }
        /// <summary>
        /// Get particular device by Id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        Device GetDeviceId(int deviceId);
        /// <summary>
        /// Get new device
        /// </summary>
        IEnumerable<Device> NewDevice { get; }

    }
}
