using EventfulSearch.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Data
{
    [Export(typeof(IInitializer))]
    public class Initializer : IInitializer
    {
        public void Init(IRegistrar registrar)
        {
            registrar.RegisterType<IGeoCodeData, GeoCodeData>();
            registrar.RegisterType<IEventfulSearchData, EventfulSearchData>();
        }
    }
}
