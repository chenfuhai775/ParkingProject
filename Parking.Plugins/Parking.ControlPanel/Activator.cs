using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace Parking.ControlPanel
{
    public class Activator : IBundleActivator
    {
        public static IBundleContext Context { private set; get; }
        public void Start(IBundleContext context)
        {
            //todo:
            Context = context;
            Activator.Context.ExtensionChanged += ExtensionContainer.Instance.Context_ExtensionChanged;
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
