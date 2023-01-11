using Android.Content;
using Android.Locations;
using Android.Runtime;
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
        var lm = Android.App.Application.Context
            .GetSystemService(Context.LocationService)
            .JavaCast<LocationManager>();

        return lm.GnssHardwareModelName;
    }
}
