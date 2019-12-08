using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Parking.Core.OSGI;
using UIShell.OSGi;
using Parking.Core.Enum;

namespace Parking.Core.Extension
{
    public class ExtensionContainerBase
    {
        #region __类内变量__
        private string EXTENS_POINT;
        public ExtensionContainerBase(string extens)
        {
            EXTENS_POINT = extens;
        }
        #endregion

        #region __获取子扩展点信息__
        /// <summary>
        /// 获取子扩展点信息
        /// </summary>
        /// <param name="EXTENS_POINT"></param>
        /// <returns></returns>
        public List<WinShellApplication> GetChildrenExtensions(IBundleContext Context)
        {
            List<WinShellApplication> WinShellAppCollections = new List<WinShellApplication>();
            var extensions = Context.GetExtensions(EXTENS_POINT);
            string extensType = string.Empty;
            string extensName = string.Empty;
            foreach (var extension in extensions)
            {
                foreach (XmlNode node in extension.Data)
                {
                    if (node is XmlComment)
                        continue;
                    WinShellApplication app = new WinShellApplication();
                    app.Bundle = extension.Owner;

                    if (!string.IsNullOrEmpty(node.Attributes["Text"].Value))
                        app.ExtensName = node.Attributes["Text"].Value;

                    if (!string.IsNullOrEmpty(node.Attributes["ToolTip"].Value))
                        app.ExtensText = node.Attributes["ToolTip"].Value;

                    if (!string.IsNullOrEmpty(node.Attributes["Class"].Value))
                        app.ExtensType = node.Attributes["Class"].Value;

                    if (!string.IsNullOrEmpty(node.Attributes["Icon"].Value))
                        app.Icon = node.Attributes["Icon"].Value;

                    if (null != node.Attributes["OperaterType"] && !string.IsNullOrEmpty(node.Attributes["OperaterType"].Value))
                        app.OperaterType = (enumOperaterType)(System.Enum.Parse(typeof(enumOperaterType), node.Attributes["OperaterType"].Value, false));
                    WinShellAppCollections.Add(app);
                }
            }
            return WinShellAppCollections;
        }
        #endregion
    }
}