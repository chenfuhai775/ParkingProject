namespace Parking.BasePanel
{
    using Parking.Core;
    using Parking.Core.DataProcessing;
    using Parking.Core.Extension;
    using Parking.Core.Infrastructure;
    using Parking.Core.Log4Net;
    using Parking.Core.Model;
    using Parking.Core.OSGI;
    using Parking.Core.Record;
    using Parking.DBService.IBLL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class BaseControl : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        private int topTitleHeight = 60;

        public BaseControl(FN_LAYOUT_SUBJECT pluginInfo)
        {
            this.InitializeComponent();
            this._Plugin = pluginInfo;
        }

        private void BaseControl_Load(object sender, EventArgs e)
        {
            this.picCar.Location = new Point(20, 20);
            this.picCar.Image = new Bitmap(GlobalEnvironment.BasePath + @"\Image\car.png");
            this.lbTitle.Location = new Point(50, 20);
            this.pLine.Location = new Point(20, 50);
            this.pLine.Width = base.Width - 40;
            this.pLine.Height = 1;
            this.lbTitle.Text = this._Plugin.TITLE;
            ExtensionContainer.Instance.OnExtensionChanged += new ExtensionContainer.OnExtensionChangedEventHandler(this.Instance_OnExtensionChanged);
            ExtensionContainer.Instance.onExtensionChanged();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            try
            {
                WinShellApplication tag = ((PictureBox)sender).Tag as WinShellApplication;
                ProcessRecord recordinfo = new ProcessRecord
                {
                    OPERATER_TYPE = tag.OperaterType
                };
                ThreadMessageTransact.Instance.triggerEvent(recordinfo, false);
            }
            catch (Exception exception)
            {
                LogHelper.Log.Error(exception.Message);
            }
        }

        public void InitExtensionControl(ExtensionArgs args)
        {
            MethodInvoker method = null;
            try
            {
                if (base.InvokeRequired)
                {
                    if (method == null)
                    {
                        method = () => this.InitExtensionControl(args);
                    }
                    base.Invoke(method);
                }
                else
                {
                    List<FN_LAYOUT_SUBJECT> plugins = EngineContext.Current.Resolve<IFN_LAYOUT_SUBJECT>().GetPlugins(GlobalEnvironment.WorkStationInfo.ID, this._Plugin.ID);
                    using (List<FN_LAYOUT_SUBJECT>.Enumerator enumerator = plugins.GetEnumerator())
                    {
                        Func<WinShellApplication, bool> predicate = null;
                        FN_LAYOUT_SUBJECT pluginInfo;
                        while (enumerator.MoveNext())
                        {
                            pluginInfo = enumerator.Current;
                            if (predicate == null)
                            {
                                predicate = x => x.ExtensName == pluginInfo.CLIENT_TYPE;
                            }
                            WinShellApplication application = args.extensions.Where<WinShellApplication>(predicate).FirstOrDefault<WinShellApplication>();
                            if (null != application)
                            {
                                decimal? nullable2;
                                UserControl control = System.Activator.CreateInstance(application.Bundle.LoadClass(application.ExtensType), new object[] { pluginInfo }) as UserControl;
                                decimal? wIDTH = pluginInfo.WIDTH;
                                decimal width = base.Width;
                                nullable2 = (wIDTH.HasValue ? new decimal?(wIDTH.GetValueOrDefault() * width) : ((decimal?)(nullable2 = null))) / 100M;
                                control.Width = (int)nullable2.Value;
                                wIDTH = pluginInfo.HEIGHT;
                                width = base.Height;
                                nullable2 = (wIDTH.HasValue ? new decimal?(wIDTH.GetValueOrDefault() * width) : ((decimal?)(nullable2 = null))) / 100M;
                                control.Height = (int)nullable2.Value;
                                wIDTH = pluginInfo.LEEF_X;
                                width = base.Width;
                                nullable2 = (wIDTH.HasValue ? new decimal?(wIDTH.GetValueOrDefault() * width) : ((decimal?)(nullable2 = null))) / 100M;
                                int num = (int)nullable2.Value;
                                wIDTH = pluginInfo.LEEF_Y;
                                width = base.Height;
                                nullable2 = (wIDTH.HasValue ? new decimal?(wIDTH.GetValueOrDefault() * width) : ((decimal?)(nullable2 = null))) / 100M;
                                int y = ((int)nullable2.Value) + this.topTitleHeight;
                                y = ((y + this.topTitleHeight) > base.Height) ? (base.Height - control.Height) : y;
                                control.Location = new Point(num, y);
                                base.Controls.Add(control);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                LogHelper.Log.Error(exception.Message);
            }
        }

        public void Instance_OnExtensionChanged(object sender, ExtensionArgs args)
        {
            this.InitExtensionControl(args);
        }

        public string Title
        {
            set
            {
                this.lbTitle.Text = value;
            }
        }
    }
}

