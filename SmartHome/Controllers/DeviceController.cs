using System.Collections.Generic;
using System.Linq;
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

        public ViewResult List(string section)
        {
            IEnumerable<Device> devices;
            string currentSection;

            if (string.IsNullOrEmpty(section))
            {
                devices = _deviceRepository.AllDevices.OrderBy(d => d.DeviceId);
                currentSection = "All devices";
            }
            else
            {
                devices = _deviceRepository.AllDevices.Where(d => d.Section.SectionName == section).OrderBy(d => d.DeviceId);
                currentSection = _sectionRepository.AllSections.FirstOrDefault(s => s.SectionName == section)?.SectionName;
            }



            return View(new DevicesListViewModel
            {
                Devices = devices,
                CurrentSection = currentSection
            });
        }
        public IActionResult Details(int id)
        {
            var device = _deviceRepository.GetDeviceId(id);
            if (device == null)
                return NotFound();

            return View(device);
        }
        public IActionResult Index()
        {
            return View(); 
        }
    }
}