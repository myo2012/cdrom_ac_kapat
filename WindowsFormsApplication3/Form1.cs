using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region CD ROM AÇ Kapat
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string x, string y, int a, int b);


        private void btnCD_ac_Click(object sender, EventArgs e)
        {
            mciSendString("set CDAudio door open", null, 127, 0);
        }

        private void btnCD_kapa_Click(object sender, EventArgs e)
        {
            mciSendString("set CDAudio door closed", null, 127, 0);
        } 
        #endregion

        #region aciksüre
        [DllImport("kernel32.dll")]
        public static extern long GetTickCount();


        private void btn_acik_sure_Click(object sender, EventArgs e)
        {

            // GetTickCount() metodu bilgisyarın ne kadar süredir açık olduğunu milisecond 
            //süre olarak verir.

            long gecenDakika = GetTickCount() / 1000 / 60;

            lblSure.Text = "Bilgisayar " + gecenDakika.ToString() + " dakikadır açık";
        } 
        #endregion



        #region Yan Son
        [DllImport("user32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd,bool bInvert);

        private void btnYanSon_Click(object sender, EventArgs e)
        {

            frmYanSon frmY = new frmYanSon();
            frmY.Show();

            for (int i = 0; i <= 4; i++)
            {
                Thread.Sleep(300);

                FlashWindow(frmY.Handle, true);
            }

            

        } 
        #endregion

        #region Animasyon

        const int AW_HIDE=65536;
        const int AW_ACTIVATE = 131072;
        const int AW_HOR_POSITIVE = 1;
        const int AW_SLIDe = 262144;
        const int AW_BLEND = 524288;
        public const int AW_VER_NEGATIVE = 8;

        [DllImport("user32.dll")]

        private static extern int AnimateWindow(IntPtr hwdn, int dwTime, int dwFlags);

        private void btnAnimasyon_Click(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 2000, AW_HOR_POSITIVE | AW_HIDE);

            AnimateWindow(this.Handle, 2000, AW_SLIDe|AW_BLEND);

        }

        #endregion

        private void btnAnimasyon2_Click(object sender, EventArgs e)
        {
            frmYanSon frmY = new frmYanSon();
            AnimateWindow(frmY.Handle, 3000, AW_VER_NEGATIVE|AW_SLIDe);
            frmY.Show();
        }
    }
}
