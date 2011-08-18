using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FQM
{
    public partial class FolderManager : Form
    {
        #region Private Field

        private FQM.Model.JobQualityFolder jobFolder = null;

        #endregion

        public FolderManager()
        {
            InitializeComponent();
        }

        #region Menu Item Click

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (jobFolder != null && jobFolder.IsDirty)
                {
                    DialogResult res = MessageBox.Show(this, "Do you want to save job folder:\n" + jobFolder.RootPath, "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (res == DialogResult.Yes)
                    {
                        jobFolder.Save();
                    }
                }

                jobFolder = new Model.JobQualityFolder(folderBrowserDialog.SelectedPath);
                this.RefreshGUI();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobFolder.Save();
        }
        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jobFolder == null ) return;

            if (jobFolder.IsDirty)
            {
                DialogResult res = MessageBox.Show(this, "Do you want to save job folder:\n" + jobFolder.RootPath, "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Cancel)
                {
                    return;
                }
                else if (res == DialogResult.Yes)
                {
                    jobFolder.Save();
                }
            }

            jobFolder = null;
            this.RefreshGUI();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jobFolder.IsDirty)
            {
                jobFolder.Save();
            }
        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hideOptionalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void RefreshGUI()
        { 

        }

    }
}
