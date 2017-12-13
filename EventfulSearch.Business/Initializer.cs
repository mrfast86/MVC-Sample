using EventfulSearch.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Business
{
    [Export(typeof(IInitializer))]
    public class Initializer : IInitializer
    {
        public void Init(IRegistrar registrar)
        {
            registrar.RegisterType<IGeoCodeDomain, GeoCodeDomain>();
            registrar.RegisterType<IEventfulSearchDomain, EventfulSearchDomain>();
        }
    }
}
