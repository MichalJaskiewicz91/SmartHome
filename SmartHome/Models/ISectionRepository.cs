using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public interface ISectionRepository
    {
        /// <summary>
        /// Get all sections
        /// </summary>
        IEnumerable<Section> AllSections { get; }
    }
}
