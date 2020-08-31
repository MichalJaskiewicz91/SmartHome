using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class SectionRepository : ISectionRepository
    {
        private readonly AppDbContext _appDbContext;

        public SectionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Section> AllSections => _appDbContext.Sections;
    }
}
