namespace FQM
{
    partial class FolderManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideOptionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.templateGroup = new System.Windows.Forms.GroupBox();
            this.templateView = new BrightIdeasSoftware.ObjectListView();
            this.statusColumnFQM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contentColumnFQM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.countColumnFQM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fileGroup = new System.Windows.Forms.GroupBox();
            this.folderView = new BrightIdeasSoftware.TreeListView();
            this.treeColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnMapping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnModify = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnFileType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mainMenuStrip.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.templateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateView)).BeginInit();
            this.fileGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.jobToolStripMenuItem,
            this.editToolStripMenuItem,
            this.templateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(817, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.jobToolStripMenuItem.Text = "Job";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::FQM.Resource.New;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::FQM.Resource.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::FQM.Resource.Close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::FQM.Resource.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::FQM.Resource.SaveAs;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem,
            this.importFolderToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Image = global::FQM.Resource.ImportFile;
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.importFileToolStripMenuItem.Text = "Import File";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // importFolderToolStripMenuItem
            // 
            this.importFolderToolStripMenuItem.Image = global::FQM.Resource.ImportFolder;
            this.importFolderToolStripMenuItem.Name = "importFolderToolStripMenuItem";
            this.importFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.importFolderToolStripMenuItem.Text = "Import Folder";
            this.importFolderToolStripMenuItem.Click += new System.EventHandler(this.importFolderToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Image = global::FQM.Resource.Move;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::FQM.Resource.Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::FQM.Resource.Refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideOptionalToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.toolStripSeparator2});
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.templateToolStripMenuItem.Text = "Template";
            // 
            // hideOptionalToolStripMenuItem
            // 
            this.hideOptionalToolStripMenuItem.Image = global::FQM.Resource.Hide;
            this.hideOptionalToolStripMenuItem.Name = "hideOptionalToolStripMenuItem";
            this.hideOptionalToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hideOptionalToolStripMenuItem.Text = "Hide Optional";
            this.hideOptionalToolStripMenuItem.Click += new System.EventHandler(this.hideOptionalToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTemplateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updateTemplateToolStripMenuItem
            // 
            this.updateTemplateToolStripMenuItem.Name = "updateTemplateToolStripMenuItem";
            this.updateTemplateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updateTemplateToolStripMenuItem.Text = "Update Template";
            this.updateTemplateToolStripMenuItem.Click += new System.EventHandler(this.updateTemplateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.templateGroup);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.fileGroup);
            this.splitContainer.Size = new System.Drawing.Size(817, 583);
            this.splitContainer.SplitterDistance = 317;
            this.splitContainer.TabIndex = 4;
            // 
            // templateGroup
            // 
            this.templateGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.templateGroup.Controls.Add(this.templateView);
            this.templateGroup.Location = new System.Drawing.Point(4, 4);
            this.templateGroup.Name = "templateGroup";
            this.templateGroup.Size = new System.Drawing.Size(313, 576);
            this.templateGroup.TabIndex = 0;
            this.templateGroup.TabStop = false;
            this.templateGroup.Text = "Template";
            // 
            // templateView
            // 
            this.templateView.AllColumns.Add(this.statusColumnFQM);
            this.templateView.AllColumns.Add(this.contentColumnFQM);
            this.templateView.AllColumns.Add(this.countColumnFQM);
            this.templateView.AllowDrop = true;
            this.templateView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.templateView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusColumnFQM,
            this.contentColumnFQM,
            this.countColumnFQM});
            this.templateView.GridLines = true;
            this.templateView.HeaderUsesThemes = false;
            this.templateView.HideSelection = false;
            this.templateView.HighlightBackgroundColor = System.Drawing.Color.Crimson;
            this.templateView.HighlightForegroundColor = System.Drawing.Color.DarkGreen;
            this.templateView.Location = new System.Drawing.Point(6, 20);
            this.templateView.Name = "templateView";
            this.templateView.Size = new System.Drawing.Size(301, 551);
            this.templateView.TabIndex = 0;
            this.templateView.UseCompatibleStateImageBehavior = false;
            this.templateView.View = System.Windows.Forms.View.Details;
            this.templateView.DragDrop += new System.Windows.Forms.DragEventHandler(this.templateView_DragDrop);
            this.templateView.DragEnter += new System.Windows.Forms.DragEventHandler(this.templateView_DragEnter);
            // 
            // statusColumnFQM
            // 
            this.statusColumnFQM.IsEditable = false;
            this.statusColumnFQM.MaximumWidth = 20;
            this.statusColumnFQM.MinimumWidth = 20;
            this.statusColumnFQM.Text = "Status";
            this.statusColumnFQM.Width = 20;
            // 
            // contentColumnFQM
            // 
            this.contentColumnFQM.AspectName = "Content";
            this.contentColumnFQM.IsEditable = false;
            this.contentColumnFQM.Text = "Content";
            this.contentColumnFQM.Width = 186;
            // 
            // countColumnFQM
            // 
            this.countColumnFQM.AspectName = "Present";
            this.countColumnFQM.Text = "Count";
            // 
            // fileGroup
            // 
            this.fileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGroup.Controls.Add(this.folderView);
            this.fileGroup.Location = new System.Drawing.Point(4, 4);
            this.fileGroup.Name = "fileGroup";
            this.fileGroup.Size = new System.Drawing.Size(489, 576);
            this.fileGroup.TabIndex = 0;
            this.fileGroup.TabStop = false;
            this.fileGroup.Text = "Job folder tree";
            // 
            // folderView
            // 
            this.folderView.AllColumns.Add(this.treeColumnName);
            this.folderView.AllColumns.Add(this.treeColumnMapping);
            this.folderView.AllColumns.Add(this.treeColumnModify);
            this.folderView.AllColumns.Add(this.treeColumnSize);
            this.folderView.AllColumns.Add(this.treeColumnFileType);
            this.folderView.AllowDrop = true;
            this.folderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.folderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.treeColumnName,
            this.treeColumnMapping,
            this.treeColumnModify,
            this.treeColumnSize,
            this.treeColumnFileType});
            this.folderView.EmptyListMsg = "Create/Open a job folder";
            this.folderView.Location = new System.Drawing.Point(6, 20);
            this.folderView.Name = "folderView";
            this.folderView.OverlayText.InsetX = 40;
            this.folderView.OverlayText.Rotation = -90;
            this.folderView.OverlayText.Text = "";
            this.folderView.OwnerDraw = true;
            this.folderView.ShowGroups = false;
            this.folderView.Size = new System.Drawing.Size(477, 551);
            this.folderView.TabIndex = 0;
            this.folderView.UseCompatibleStateImageBehavior = false;
            this.folderView.View = System.Windows.Forms.View.Details;
            this.folderView.VirtualMode = true;
            // 
            // treeColumnName
            // 
            this.treeColumnName.AspectName = "Name";
            this.treeColumnName.IsTileViewColumn = true;
            this.treeColumnName.MinimumWidth = 100;
            this.treeColumnName.Text = "File Name";
            this.treeColumnName.UseInitialLetterForGroup = true;
            this.treeColumnName.Width = 200;
            // 
            // treeColumnMapping
            // 
            this.treeColumnMapping.Text = "Mapping";
            this.treeColumnMapping.Width = 150;
            // 
            // treeColumnModify
            // 
            this.treeColumnModify.AspectName = "LastWriteTime";
            this.treeColumnModify.IsEditable = false;
            this.treeColumnModify.Text = "Modify";
            // 
            // treeColumnSize
            // 
            this.treeColumnSize.AspectName = "Extension";
            this.treeColumnSize.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumnSize.IsEditable = false;
            this.treeColumnSize.Text = "size";
            this.treeColumnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // treeColumnFileType
            // 
            this.treeColumnFileType.IsEditable = false;
            this.treeColumnFileType.IsTileViewColumn = true;
            this.treeColumnFileType.Text = "File Type";
            // 
            // FolderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 607);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FolderManager";
            this.Text = "FQM Folder Manager";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.templateGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templateView)).EndInit();
            this.fileGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideOptionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox templateGroup;
        private BrightIdeasSoftware.ObjectListView templateView;
        private BrightIdeasSoftware.OLVColumn statusColumnFQM;
        private BrightIdeasSoftware.OLVColumn contentColumnFQM;
        private BrightIdeasSoftware.OLVColumn countColumnFQM;
        private System.Windows.Forms.GroupBox fileGroup;
        private BrightIdeasSoftware.TreeListView folderView;
        private BrightIdeasSoftware.OLVColumn treeColumnName;
        private BrightIdeasSoftware.OLVColumn treeColumnMapping;
        private BrightIdeasSoftware.OLVColumn treeColumnModify;
        private BrightIdeasSoftware.OLVColumn treeColumnSize;
        private BrightIdeasSoftware.OLVColumn treeColumnFileType;
    }
}