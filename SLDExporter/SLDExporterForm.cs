using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SLDExporter
{
    public partial class SLDExporterForm : Form
    {
        private ILayer selectedLayer = null;
        private IDataset dataset = null;
        private IFeatureLayer featureLayer = null;
        private IGeoFeatureLayer geoFeatureLayer = null;
        private IFeatureRenderer featureRenderer = null;
        private IFeatureClass featureClass = null;
        private IFeatureCursor featureCursor = null;
        private IFeature feature = null;

        private ISimpleRenderer simpleRenderer = null;
        private ISymbol symbol = null;
        private IFillSymbol fillSymbol = null;
        private Color fillColor;
        private Color outlineColor;
        
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

        private void buttonExportSLD_Click(object sender, EventArgs e)
        {
            try
            {
                selectedLayer = ArcMap.Document.SelectedLayer;
                dataset = (IDataset)selectedLayer;
                featureLayer = (IFeatureLayer)selectedLayer;
                geoFeatureLayer = (IGeoFeatureLayer)featureLayer;
                featureRenderer = geoFeatureLayer.Renderer;
                featureClass = featureLayer.FeatureClass;

                string rendererID = geoFeatureLayer.RendererPropertyPageClassID.Value.ToString();
                string fillColorHEX;
                string outlineColorHEX;
                string outlineWidth;
                
                if (rendererID == SLDExporterResource.SimpleRenderer || rendererID == SLDExporterResource.NullRenderer)
                {
                    featureCursor = featureClass.Search(null, false);
                    feature = featureCursor.NextFeature();
                    simpleRenderer = (ISimpleRenderer)featureRenderer;
                    symbol = simpleRenderer.Symbol;
                    fillSymbol = (IFillSymbol)symbol;

                    fillColor = ColorTranslator.FromOle(fillSymbol.Color.RGB);
                    fillColorHEX = String.Format("#{0:X6}", fillColor.ToArgb() & 0x00FFFFFF);

                    outlineColor = ColorTranslator.FromOle(fillSymbol.Outline.Color.RGB);
                    outlineColorHEX = String.Format("#{0:X6}", outlineColor.ToArgb() & 0x00FFFFFF);

                    outlineWidth = fillSymbol.Outline.Width.ToString();
                    string simpleSldXml = String.Format(SLDExporterResource.SimpleSLD, textBoxGSsldName.Text, fillColorHEX, outlineColorHEX, outlineWidth);

                    //string path = "C:\\Users\\seroman\\Desktop\\sld_denemesi_haci_abi.sld";
                    
                    //StreamWriter file = new System.IO.StreamWriter(path);
                    //file.WriteLine(simpleSldXml);
                    //file.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
