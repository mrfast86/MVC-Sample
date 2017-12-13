using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Common
{
    public interface IInitializer
    {
        void Init(IRegistrar registrar);
    }
}
