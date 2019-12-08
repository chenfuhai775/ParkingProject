using System;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using UIShell.OSGi;
using Parking.Core.Extension;

namespace Parking.WorkBench
{
    public class ExtensionContainer : ExtensionContainerBase
    {
        #region __类内变量__
        public const string EXTENS_POINT = "Parking.WorkBench";
        private static object _lock = new object();
        private static ExtensionContainer container = null;
        #endregion

        #region __构造函数__
        public ExtensionContainer() : base(EXTENS_POINT) { }
        #endregion

        #region __单列对象__
        /// <summary>
        /// 单列对象
        /// </summary>
        public static ExtensionContainer Instance
        {
            get
            {
                if (null == container)
                    lock (_lock)
                    {
                        container = new ExtensionContainer();
                    }
                return container;
            }
        }
        #endregion

        #region __扩展点变动事件__
        public delegate void OnExtensionChangedEventHandler(object sender, ExtensionArgs args);
        public event OnExtensionChangedEventHandler OnExtensionChanged;
        public void Context_ExtensionChanged(object sender, UIShell.OSGi.ExtensionEventArgs e)
        {
            if (e.ExtensionPoint.Equals(EXTENS_POINT))
                onExtensionChanged();
        }
        public void onExtensionChanged()
        {
            var extensions = GetChildrenExtensions(Activator.Context);
            if (null != OnExtensionChanged)
            {
                OnExtensionChanged(this, new ExtensionArgs() { extensions = extensions });
            }
        }
        #endregion
    }
}