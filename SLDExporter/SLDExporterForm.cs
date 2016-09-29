using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLDExporter
{
    public partial class SLDExporterForm : Form
    {
        public SLDExporterForm()
        {
            InitializeComponent();
        }

        private void SLDExporterForm_Load(object sender, EventArgs e)
        {

        }

        private void labelGSusername_Click(object sender, EventArgs e)
        {

        }

        private void buttonGSconnect_Click(object sender, EventArgs e)
        {
            string geoserverurl = textBoxGSurl.Text.Trim();
            string username = textBoxGSusername.Text.Trim();
            string password = textBoxGSpassword.Text.Trim();



        }

        private void buttonGSpublishSLD_Click(object sender, EventArgs e)
        {

        }

        private void buttonGSaddStyleToLayer_Click(object sender, EventArgs e)
        {

        }
    }
}
