namespace Parking.BasePanel
{
    using Parking.Core.Extension;
    using Parking.Core.OSGI;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using UIShell.OSGi;

    public class ExtensionContainer : ExtensionContainerBase
    {
        private static object _lock = new object();
        private static ExtensionContainer container = null;
        public const string EXTENS_POINT = "Parking.BasePanel";

        public event OnExtensionChangedEventHandler OnExtensionChanged;

        public ExtensionContainer()
            : base(EXTENS_POINT)
        {
        }

        public void Context_ExtensionChanged(object sender, ExtensionEventArgs e)
        {
            if (e.ExtensionPoint.Equals(EXTENS_POINT))
            {
                this.onExtensionChanged();
            }
        }

        public void onExtensionChanged()
        {
            List<WinShellApplication> childrenExtensions = base.GetChildrenExtensions(Activator.Context);
            if (null != this.OnExtensionChanged)
            {
                ExtensionArgs args = new ExtensionArgs {
                    extensions = childrenExtensions
                };
                this.OnExtensionChanged(this, args);
            }
        }

        public static ExtensionContainer Instance
        {
            get
            {
                if (null == container)
                {
                    lock (_lock)
                    {
                        container = new ExtensionContainer();
                    }
                }
                return container;
            }
        }

        public delegate void OnExtensionChangedEventHandler(object sender, ExtensionArgs args);
    }
}

