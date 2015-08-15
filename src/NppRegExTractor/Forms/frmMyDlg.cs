using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NppRegExTractorPlugin
{
    public partial class frmMyDlg : Form
    {
        public frmMyDlg()
        {
            InitializeComponent();
        }

        private void bntSeachLogDir_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogLogDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxLogDir.Text = folderBrowserDialogLogDir.SelectedPath;
            }
        }

        private void btnSelectSearchFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogSearchFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSearchTermsFile.Text = openFileDialogSearchFile.FileName;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var directory = textBoxLogDir.Text;
            var searchTermFile = textBoxSearchTermsFile.Text;
            var recursive = cbRecursive.Checked;
            var filter = textBoxFileFilter.Text;
            var outputFile = tbOutputFile.Text;


            //MessageBox.Show(String.Format("Dir: {0}, Rec: {1}, Filter: {2}, SearchTerms: {3}, Output: {4}",
              //  directory, recursive, filter, searchTermFile, outputFile));

            var regextractorassembly = Assembly.LoadFrom(@"plugins\RegExtractor\RegExTractorModules.dll");
            //MessageBox.Show("Registerd Assembly");

            Type type = regextractorassembly.GetType("RegExTractorModules.RegExTractorSimpleWorkflow");
            //MessageBox.Show("Registerd type");
            
            var method = type.GetMethod("Process");
            //MessageBox.Show("Registerd Method");


            object activator = Activator.CreateInstance(type);
            //MessageBox.Show("Registerd Activator");
            
            method.Invoke(activator, new object[] { directory, recursive, filter, searchTermFile, outputFile });
            //var workflow = new RegExTractorSimpleWorkflow();
            //workflow.Process(directory, recursive, filter, searchTermFile, outputFile);
            
        }

        private void btnSelectOutputFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOutputFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbOutputFile.Text = saveFileDialogOutputFile.FileName;
            }
        }
        

    }
}
