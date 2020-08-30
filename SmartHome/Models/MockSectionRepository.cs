using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class MockSectionRepository: ISectionRepository
    {
        // Hardcoded list of sections
        public IEnumerable<Section> AllSections =>
            new List<Section>
            {
                new Section{SectionId=1, SectionName="Electricity",Description="Lighting"},
                new Section{SectionId=2, SectionName="HVAC",Description="Heating and Air conditioning"},
                new Section{SectionId=3, SectionName="Others",Description="Rest od controlled devices"},
            };
    }
}
