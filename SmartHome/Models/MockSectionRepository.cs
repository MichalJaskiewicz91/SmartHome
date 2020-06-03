using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class MockSectionRepository: IDeviceRepository
    {
        public IEnumerable<Section> AllSections =>
            new List<Section>
            {
                new Section{SecctionId=1, SectionName="Electricity",Description="Lighting"}
            };
    }
}
