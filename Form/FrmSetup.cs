using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using RTC3D.UserControl.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTC3D.Form
{
    public partial class FrmSetup : DevExpress.XtraEditors.XtraForm
    {
        private uc_list_tool ucListTool;
        private uc_config_tools ucConfigTools;
        public FrmSetup()
        {
            InitializeComponent();
            
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {

            ucListTool = new uc_list_tool
            {
                Dock = DockStyle.Fill
            };
            ucConfigTools = new uc_config_tools
            {
                Dock = DockStyle.Fill
            };
            splitContainerControl1.Panel1.Controls.Add(ucListTool);
            splitContainerControl2.Panel1.Controls.Add(ucConfigTools);
        }
    }
}