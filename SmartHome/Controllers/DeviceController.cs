using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using SmartHome.ViewModels;

namespace SmartHome.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly ISectionRepository _sectionRepository;

        public DeviceController(IDeviceRepository deviceRepository, ISectionRepository sectionRepository)
        {
            _deviceRepository = deviceRepository;
            _sectionRepository = sectionRepository;
        }

        public ViewResult List()
        {
            DevicesListViewModel deviceListViewModel = new DevicesListViewModel();
            deviceListViewModel.Devices = _deviceRepository.AllDevices;

            deviceListViewModel.CurrentSection = "HVAC";


            return View(deviceListViewModel);
        }
        public IActionResult Index()
        {
            return View(); 
        }
    }
}