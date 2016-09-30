using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
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
using stdole;


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

        string rendererID;
        string fillColorHEX;
        string outlineColorHEX;
        string outlineWidth;

        private IAnnotateLayerPropertiesCollection annotateLPC = null;
        private IAnnotateLayerProperties annotateLP = null;
        private IElementCollection elementCol = null;
        private IElementCollection elementCol2 = null;
        private ILabelEngineLayerProperties leProps = null;
        private ITextSymbol textSymbol = null;
        bool labelOpenOrClosed;
        string labelField;
        private IFontDisp labelFont;
        string labelFontFamily;
        string labelSize;

        string simpleSldXmlWithoutLabel;
        string simpleSldXmlWithLabel;

        string sldNameOnServer;

        string geoserverUsername;
        string geoserverPassword;
        
        public SLDExporterForm()
        {
            InitializeComponent();
            textBoxGSurl.ForeColor = Color.LightGray;
            textBoxGSurl.Text = "http://0.0.0.0:8080/geoserver";
            this.textBoxGSurl.Leave += new EventHandler(this.textBoxGSurl_Leave);
            this.textBoxGSurl.Enter += new EventHandler(this.textBoxGSurl_Enter);

            try
            {
                selectedLayer = ArcMap.Document.SelectedLayer;
                dataset = (IDataset)selectedLayer;
                featureLayer = (IFeatureLayer)selectedLayer;
                geoFeatureLayer = (IGeoFeatureLayer)featureLayer;
                featureRenderer = geoFeatureLayer.Renderer;
                featureClass = featureLayer.FeatureClass;
                rendererID = geoFeatureLayer.RendererPropertyPageClassID.Value.ToString();
                labelOpenOrClosed = geoFeatureLayer.DisplayAnnotation;
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure you select a layer in the Table Of Contents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            geoserverUsername = textBoxGSusername.Text.Trim();
            geoserverPassword = textBoxGSpassword.Text.Trim();
            string geoserverUrl = textBoxGSurl.Text.Trim() + "/rest/workspaces.xml";
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
            try 
	        {
                string geoserverUrl = String.Format(textBoxGSurl.Text.Trim() + "/rest/workspaces/{0}/styles.xml", comboBoxGSworkspaces.Text);
                var client = new RestClient(geoserverUrl);
                client.Authenticator = new HttpBasicAuthenticator(geoserverUsername, geoserverPassword);
                var request = new RestRequest(Method.POST);
                sldNameOnServer = String.Format("<style><name>{0}</name><filename>{0}.sld</filename></style>", textBoxGSsldName.Text);
                request.AddHeader("Content-type", "text/xml");
                request.AddParameter("text/xml", sldNameOnServer, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.StatusCode.ToString() == "Created") //&& sld'nin upload olma durumu
	            {
                    MessageBox.Show("Layer style has been successfully created on the server.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
	            }
	        }
	        catch (Exception)
	        {
                MessageBox.Show("Internal Server Error - Please make sure you've connected to GeoServer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void buttonGSaddStyleToLayer_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportSLD_Click(object sender, EventArgs e)
        {
            try
            {
                if (featureClass.ShapeType == esriGeometryType.esriGeometryPoint)
                {
                    MessageBox.Show("point feature class");
                }

                if (featureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
                {
                    MessageBox.Show("line feature class");
                }

                if (featureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
                {
                    if (rendererID == SLDExporterResource.SimpleRenderer || rendererID == SLDExporterResource.NullRenderer)
                    {
                        SimpleRendererPolygon(rendererID);
                    }
                    
                }
       
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please make sure you select a layer in the Table Of Contents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }    
        }

        private void SimpleRendererPolygon(string rendererID)
        {
            simpleRenderer = (ISimpleRenderer)featureRenderer;
            symbol = simpleRenderer.Symbol;
            fillSymbol = (IFillSymbol)symbol;

            fillColor = ColorTranslator.FromOle(fillSymbol.Color.RGB);
            fillColorHEX = String.Format("#{0:X6}", fillColor.ToArgb() & 0x00FFFFFF);

            outlineColor = ColorTranslator.FromOle(fillSymbol.Outline.Color.RGB);
            outlineColorHEX = String.Format("#{0:X6}", outlineColor.ToArgb() & 0x00FFFFFF);

            outlineWidth = fillSymbol.Outline.Width.ToString().Replace(",", ".");
            
            ExportSLD(labelOpenOrClosed);
        }

        public void ExportSLD(bool labelStatus)
        {
            if (labelStatus == true)
            {
                annotateLPC = geoFeatureLayer.AnnotationProperties;
                annotateLPC.QueryItem(0, out annotateLP, out elementCol, out elementCol2);
                leProps = (ILabelEngineLayerProperties)annotateLP;
                labelField = leProps.Expression.Replace(@"[", "").Replace(@"]", "");
                textSymbol = leProps.Symbol;
                labelFont = textSymbol.Font;
                labelFontFamily = labelFont.Name;
                labelSize = textSymbol.Size.ToString().Replace(",", ".");

                simpleSldXmlWithLabel = String.Format(SLDExporterResource.SimpleSLDwithLabel, textBoxGSsldName.Text, fillColorHEX, outlineColorHEX, outlineWidth, labelField, labelFontFamily, labelSize);

                string path = "C:\\Users\\seroman\\Desktop\\sld_denemesi_haci_abi.sld";
                StreamWriter file = new System.IO.StreamWriter(path);
                file.WriteLine(simpleSldXmlWithLabel);
                file.Close();
            }
            else
            {
                //sld object i direkt döndür
                simpleSldXmlWithoutLabel = String.Format(SLDExporterResource.SimpleSLDwithoutLabel, textBoxGSsldName.Text, fillColorHEX, outlineColorHEX, outlineWidth);

                string path = "C:\\Users\\seroman\\Desktop\\sld_denemesi_haci_abi.sld";
                StreamWriter file = new System.IO.StreamWriter(path);
                file.WriteLine(simpleSldXmlWithoutLabel);
                file.Close();
            }
        }
    }
}
