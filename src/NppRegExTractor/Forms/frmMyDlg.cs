using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using NppPluginNET;

namespace NppRegExTractorPlugin
{
    public partial class frmMyDlg : Form
    {
        public frmMyDlg()
        {
            InitializeComponent();
            LoadRegExTractorUI();
        }

        private void LoadRegExTractorUI()
        {
            
            StringBuilder sbIniFilePath = new StringBuilder(Win32.MAX_PATH);
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_GETPLUGINHOMEPATH, Win32.MAX_PATH, sbIniFilePath);
            
            var regextractorassembly = Assembly.LoadFrom(sbIniFilePath.ToString() + "\\NppRegExTractorPlugin\\RegExtractor\\RegExTractorWinForm.dll");
            //MessageBox.Show("Registerd Assembly");

            Type type = regextractorassembly.GetType("RegExTractorWinForm.RegExTractorMainUI");
            //MessageBox.Show("Registerd type");

            //var method = type.GetMethod("Process");
            //MessageBox.Show("Registerd Method");


            object activator = Activator.CreateInstance(type);
            //MessageBox.Show("Registerd Activator");

            this.Controls.Add(activator as Control);
            (activator as Control).Dock = DockStyle.Fill;


            //method.Invoke(activator, new object[] { directory, recursive, filter, searchTermFile, outputFile });
            //var workflow = new RegExTractorSimpleWorkflow();
            //workflow.Process(directory, recursive, filter, searchTermFile, outputFile);
        }
      

    }
}
