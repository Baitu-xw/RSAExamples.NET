using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RsaGenerateKey.NET.Common;

namespace RsaGenerateKey.NET
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int keySize = Convert.ToInt32(txtKeySize.Text);
            string savePath = txtSavePath.Text.Trim();
            XmlFormatter xmlFmt=new XmlFormatter(keySize,savePath);

            xmlFmt.GenerateKey();
            MessageBox.Show("Key Generated");
        }
    }
}
