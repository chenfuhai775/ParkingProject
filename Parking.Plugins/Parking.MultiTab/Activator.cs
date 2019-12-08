using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace Parking.MultiTab
{
    public class Activator : IBundleActivator
    {
        public static IBundleContext Context { private set; get; }
        public void Start(IBundleContext context)
        {
            //todo:
            Context = context;
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
