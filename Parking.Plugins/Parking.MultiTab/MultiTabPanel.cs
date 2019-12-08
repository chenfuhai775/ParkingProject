using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Parking.Core.Extension;
using Parking.Core.Model;

namespace Parking.MultiTab
{
    public partial class MultiTabPanel : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        public MultiTabPanel(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
        }
        private void MultiTabPanel_Load(object sender, EventArgs e)
        {
            ExtensionContainer.Instance.OnExtensionChanged += new ExtensionContainer.OnExtensionChangedEventHandler(Instance_OnExtensionChanged);
            ExtensionContainer.Instance.onExtensionChanged();
        }
        /// <summary>
        /// 添加控件
        /// </summary>
        /// <param name="extensions"></param>
        public void Instance_OnExtensionChanged(object sender, ExtensionArgs args)
        {
            InitExtensionControl(args);
        }
        public void InitExtensionControl(ExtensionArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { InitExtensionControl(args); }));
                return;
            }
            this.Controls.Clear();
            if (args.extensions.Count > 0)
            {
                TabControl tab = new TabControl();
                tab.Dock = DockStyle.Fill;
                foreach (var app in args.extensions)
                {
                    UserControl tempForm = System.Activator.CreateInstance(app.Bundle.LoadClass(app.ExtensType)) as UserControl;
                    if (null != tempForm)
                    {
                        tempForm.Dock = DockStyle.Fill;
                        tab.TabPages.Add(app.ExtensText);
                        tab.SelectTab((int)(tab.TabPages.Count - 1));
                        tempForm.Parent = tab.SelectedTab;
                        this.Controls.Add(tab);
                    }
                }
                tab.SelectTab(0);
            }
        }
    }
}