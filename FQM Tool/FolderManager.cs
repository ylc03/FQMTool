using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FQM.Model;
using FQM.Helper;

namespace FQM
{
    public partial class FolderManager : Form
    {
        #region Private Field

        private FQM.Model.JobQualityFolder jobFolder = null;

        #endregion

        #region Constructor

        public FolderManager()
        {
            InitializeComponent();

            refreshMenu();
        }

        #endregion

        #region Menu Item Click

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.saveIfNeeded();
                if (JobQualityFolder.ValidateNewPath(folderBrowserDialog.SelectedPath))
                {
                    jobFolder = new JobQualityFolder(folderBrowserDialog.SelectedPath);
                }
                else
                {
                    FQMLog.Error(folderBrowserDialog.SelectedPath + " is not empty.", "Can't create job folder");
                    jobFolder = null;
                }

                this.refreshGUI();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.saveIfNeeded();
                if (JobQualityFolder.ValidateRootPath(folderBrowserDialog.SelectedPath))
                {
                    jobFolder = new JobQualityFolder(folderBrowserDialog.SelectedPath);
                }
                else
                {
                    FQMLog.Error(folderBrowserDialog.SelectedPath + " is not a valid FQM folder.", "Can't open job folder");
                    jobFolder = null;
                }
                this.refreshGUI();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jobFolder != null && jobFolder.IsDirty)
            {
                jobFolder.Save();
            }
        }
        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jobFolder == null ) return;

            this.saveIfNeeded();
            jobFolder = null;
            this.refreshGUI();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                string root = folderBrowserDialog.SelectedPath;
                if (JobQualityFolder.ValidateRootPath(root))
                {
                    jobFolder.SaveAs(root);
                    jobFolder.IsDirty = false;
                }
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

        #region Private helper functions

        private void saveIfNeeded()
        {
            if (jobFolder != null && jobFolder.IsDirty)
            {
                DialogResult res = FQMLog.Question("Do you want to save current job folder:\n" + jobFolder.RootPath, "Save?");
                if (res == DialogResult.Cancel)
                {
                    return;
                }
                else if (res == DialogResult.Yes)
                {
                    jobFolder.Save();
                }
            }
        }

        private void refreshMenu()
        {
            if (this.jobFolder == null)
            {
                this.editToolStripMenuItem.Enabled = false;
                this.hideOptionalToolStripMenuItem.Enabled = false;
                this.saveAsToolStripMenuItem.Enabled = false;
                this.saveToolStripMenuItem.Enabled = false;
                this.closeToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.editToolStripMenuItem.Enabled = true;
                this.hideOptionalToolStripMenuItem.Enabled = true;
                this.saveAsToolStripMenuItem.Enabled = true;
                this.saveToolStripMenuItem.Enabled = true;
                this.closeToolStripMenuItem.Enabled = true;
            }
        }

        private void refreshTemplateView()
        {
            if (jobFolder == null) return;

        }

        private void refreshFolderView()
        {
            if (jobFolder == null) return;
        }

        private void refreshGUI()
        {
            this.refreshTemplateView();
            this.refreshFolderView();
            this.refreshMenu();
        }

        #endregion

        #region Template view event

        private void templateView_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void templateView_DragDrop(object sender, DragEventArgs e)
        {

        }

        #endregion

        #region folder view event

        #endregion
    }
}
