using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace csharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers
        private void btnGo_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = txtSerch.Text;

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            txtResponse.Text = strResponse;
        }

        #endregion

        private void btnJSON_Click(object sender, EventArgs e)
        {
            Form jForm = new frmJSON();
            jForm.Show();
        }
    }
}
