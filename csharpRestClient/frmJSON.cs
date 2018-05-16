using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace csharpRestClient
{
    public partial class frmJSON : Form
    {
        public frmJSON()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

        }

        private void deserialize(string strJSON)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON); //Dymamic raw JSON string. Dynamically creates a C# object
                                                                               //based on the response.

                txtResult.Text = jPerson.firstName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deserialize(txtInput.Text);
        }
    }
}
