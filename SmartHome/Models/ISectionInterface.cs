using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public interface ISectionInterface
    {
        IEnumerable<Section> AllSections { get; }
    }
}
