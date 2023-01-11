using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura;
public partial class GeolocationDevice
{
    public partial string GetName()
    {
        return Guid.NewGuid().ToString();
    }
}