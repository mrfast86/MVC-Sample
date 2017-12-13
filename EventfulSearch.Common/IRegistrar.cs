using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Common
{
    public interface IRegistrar
    {
        void RegisterType<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;

        void RegisterTypeWithContainerControlledLife<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;
    }
}
