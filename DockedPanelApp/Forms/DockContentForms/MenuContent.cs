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

namespace DockedPanelApp.Forms.DockContentForms
{
    public partial class MenuContent : DockContent
    {
        public MenuContent()
        {
            InitializeComponent();

            // Prevent this content from being closed
            CloseButton = false;

            // Hide the close button so the user isn't even tempted
            CloseButtonVisible = false;
        }
    }
}
