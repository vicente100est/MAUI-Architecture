using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura
{
    public class Guidinator : IMarkupExtension<string>
    {
        public string ProvideValue(IServiceProvider serviceProvider)
        {
            return Guid.NewGuid().ToString();
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
