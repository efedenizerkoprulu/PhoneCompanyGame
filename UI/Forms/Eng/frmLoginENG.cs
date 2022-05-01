using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Eng
{
    public partial class frmLoginENG : Form
    {
        public frmLoginENG()
        {
            InitializeComponent();
        }

        private void lblEngTurkish_Click(object sender, EventArgs e)
        {
            UI.Properties.Settings.Default.lang = "Turkish";
            UI.Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
