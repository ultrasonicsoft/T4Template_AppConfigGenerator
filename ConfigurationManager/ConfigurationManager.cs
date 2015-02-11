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
using System.Xml.Linq;

namespace ConfigurationManager
{
    public partial class ConfigurationManager : Form
    {
        public ConfigurationManager()
        {
            InitializeComponent();
        }

        private void btnLoadConfiguration_Click(object sender, EventArgs e)
        {
            //var doc = XElement.Load("Configuration.xml");
            if (File.Exists(txtConfigurationFilePath.Text) == false)
            {
                MessageBox.Show("Configuration file doesn't exists!");
                return;
            }
            var doc = XElement.Load(txtConfigurationFilePath.Text);

            tvConfiguration.Nodes.Clear();

            var rootNode = tvConfiguration.Nodes.Add("AppConfig");

            var baseAppConfigTemplateFile = doc.Element("BaseAppConfigTemplateFile");
            rootNode.Nodes.Add(baseAppConfigTemplateFile.Name.LocalName, baseAppConfigTemplateFile.Value);

            var settings = (from message in doc.Elements("Setting")
                            select new
                            {
                                EnvironmentKey = message.Attribute("environmentKey"),
                                DeploymentPath = message.Element("DeploymentPath"),
                                OutputFileExt = message.Element("OutputFileExt"),
                                Properties = message.Element("Properties").Elements("Property")
                                                    .Select(x =>
                                                        new
                                                        {
                                                            Key = x.Attribute("key").Value,
                                                            Value = x.Attribute("value").Value
                                                        }).ToList()
                            });
            foreach (var currentSetting in settings)
            {
                var currentSettingNode = rootNode.Nodes.Add(currentSetting.EnvironmentKey.Value);
                currentSettingNode.Nodes.Add(currentSetting.DeploymentPath.Name.LocalName,currentSetting.DeploymentPath.Value);
                currentSettingNode.Nodes.Add(currentSetting.OutputFileExt.Name.LocalName,currentSetting.OutputFileExt.Value);
                var propertiesNode = currentSettingNode.Nodes.Add("Properties");
                foreach (var property in currentSetting.Properties)
                {
                    propertiesNode.Nodes.Add(property.Value,property.Key);
                }

            }

        }

        private void tvConfiguration_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Name, e.Node.Text);
            txtSelectedValue.Text = e.Node.Name;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtConfigurationFilePath.Text = dialog.FileName;
            }
        }


    }

}
