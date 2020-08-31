using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SmartHome.Models
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly AppDbContext _appDbContext;
        public DeviceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Device> AllDevices
        {
            get
            {
                return _appDbContext.Devices.Include(s => s.Section);
            }
        }

        public IEnumerable<Device> NewDevice
        {
            get
            {
                return _appDbContext.Devices.Include(s => s.Section).Where(d => d.IsNew);
            }
        }

        public Device GetDeviceId(int deviceId)
        {
            return _appDbContext.Devices.FirstOrDefault(d => d.DeviceId == deviceId);
        }
    }
}
