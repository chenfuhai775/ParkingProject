using System;
using System.Collections.Generic;
using UIShell.OSGi;
using Parking.Core.Enum;

namespace Parking.Core.OSGI
{
    public class WinShellApplication
    {
        public WinShellApplication()
        {
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is WinShellApplication)
            {
                WinShellApplication other = obj as WinShellApplication;
                return Equals(BundleID, other.BundleID);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Bundle.GetHashCode();
        }
        public string ExtensName { get; set; }
        public string ExtensType { get; set; }
        public string ExtensText { get; set; }
        public enumOperaterType OperaterType { get; set; }
        public string Icon { get; set; }
        /// <summary>
        /// 定义这个Application的插件。
        /// </summary>
        public IBundle Bundle { get; set; }
        public long BundleID
        {
            get { return Bundle.BundleID; }
        }
    }
}
