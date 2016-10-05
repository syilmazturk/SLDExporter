using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SLDExporter
{
    public class SLDExporter : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public SLDExporter()
        {
        }

        protected override void OnClick()
        {
            SLDExporterForm sldGUI = new SLDExporterForm();
            sldGUI.Show();

            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
