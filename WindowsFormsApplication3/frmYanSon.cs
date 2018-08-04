using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmYanSon : Form
    {
        public frmYanSon()
        {
            InitializeComponent();
        }

        private void frmYanSon_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //formu  altta açıcak taskbar'da
        }
    }
}
