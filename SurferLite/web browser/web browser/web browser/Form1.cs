using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace web_browser
{
    public partial class FrmWebBrowser : Form
    {
        public FrmWebBrowser()
        {
            InitializeComponent();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            wbBrwsr.Navigate(txt_Url.Text);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            wbBrwsr.Stop();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            wbBrwsr.Refresh();
        }
    }
}