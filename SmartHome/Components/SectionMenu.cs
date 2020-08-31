using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;

namespace SmartHome.Components
{
    public class SectionMenu : ViewComponent
    {
        private readonly ISectionRepository _sectionRepository;

        public SectionMenu(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public IViewComponentResult Invoke()
        {
            var sections = _sectionRepository.AllSections.OrderBy(s => s.SectionName);
            return View(sections);

        }
    }
}
