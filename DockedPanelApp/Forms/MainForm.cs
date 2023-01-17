using DockedPanelApp.Forms.DockContentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockedPanelApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.mainDockPanel = new DockPanel();
            this.mainDockPanel.Dock = DockStyle.Fill;
            this.mainDockPanel.Theme = new VS2015DarkTheme();

            ShowDockContent();

            this.Controls.Add(this.mainDockPanel);
            
        }


        public void ShowDockContent()
        {
            var dockContent = new MenuContent();
            dockContent.Show(this.mainDockPanel, DockState.Document);

            var dockContent2 = new MenuContent();
            dockContent2.Show(this.mainDockPanel, DockState.Document);
        }
    }
}
