using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIShell.OSGi;

namespace Parking.WorkBench
{
    public class Activator:IBundleActivator
    {
        public static IBundleContext Context { private set; get; }
        public void Start(IBundleContext context) { }
        public void Stop(IBundleContext context) { }
    }
}
