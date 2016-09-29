using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SLDExporter
{
    public partial class SLDExporterForm : Form
    {
        public SLDExporterForm()
        {
            InitializeComponent();
            textBoxGSurl.ForeColor = Color.LightGray;
            textBoxGSurl.Text = "http://0.0.0.0:8080/geoserver";
            this.textBoxGSurl.Leave += new EventHandler(this.textBoxGSurl_Leave);
            this.textBoxGSurl.Enter += new EventHandler(this.textBoxGSurl_Enter);
        }

        private void textBoxGSurl_Leave(object sender, EventArgs e)
        {
            if (textBoxGSurl.Text == "")
            {
                textBoxGSurl.Text = "http://0.0.0.0:8080/geoserver";
                textBoxGSurl.ForeColor = Color.Gray;
            }
        }

        private void textBoxGSurl_Enter(object sender, EventArgs e)
        {
            if (textBoxGSurl.Text == "http://0.0.0.0:8080/geoserver")
            {
                textBoxGSurl.Text = "";
                textBoxGSurl.ForeColor = Color.Black;
            }
        }

        private void SLDExporterForm_Load(object sender, EventArgs e)
        {

        }

        private void labelGSusername_Click(object sender, EventArgs e)
        {

        }

        private void buttonGSconnect_Click(object sender, EventArgs e)
        {
            string geoserverUrl = textBoxGSurl.Text.Trim() + "/rest/workspaces.xml";
            string geoserverUsername = textBoxGSusername.Text.Trim();
            string geoserverPassword = textBoxGSpassword.Text.Trim();

            var client = new RestClient(geoserverUrl);
            client.Authenticator = new HttpBasicAuthenticator(geoserverUsername, geoserverPassword);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            try
            {
                var content = response.Content;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(content.ToString());
                XmlNodeList nodes = xmlDoc.DocumentElement.SelectNodes("/workspaces/workspace");

                string geoserverWorkspace;
                List<string> geoserverWorkspaceList = new List<string>();

                foreach (XmlNode node in nodes)
                {
                    geoserverWorkspace = node.SelectSingleNode("name").InnerText;
                    geoserverWorkspaceList.Add(geoserverWorkspace);
                }

                comboBoxGSworkspaces.DataSource = geoserverWorkspaceList;
            }
            catch (Exception)
            {             
                MessageBox.Show("Check connection parameters", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonGSpublishSLD_Click(object sender, EventArgs e)
        {

        }

        private void buttonGSaddStyleToLayer_Click(object sender, EventArgs e)
        {

        }
    }
}
