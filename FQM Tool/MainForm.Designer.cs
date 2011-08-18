namespace FQM
{
    partial class MainForm
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
            this.rootFolderTextBox = new System.Windows.Forms.TextBox();
            this.rootFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FQMContent = new System.Windows.Forms.GroupBox();
            this.folderFQMView = new BrightIdeasSoftware.ObjectListView();
            this.statusColumnFQM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contentColumnFQM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderTreeView = new BrightIdeasSoftware.TreeListView();
            this.treeColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnMapping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnModify = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnFileType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.treeColumnFileExtension = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.countColumnFQM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSubSegment = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.checkBoxHideOptional = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.FQMContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderFQMView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderTreeView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootFolderTextBox
            // 
            this.rootFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rootFolderTextBox.Location = new System.Drawing.Point(12, 8);
            this.rootFolderTextBox.Name = "rootFolderTextBox";
            this.rootFolderTextBox.Size = new System.Drawing.Size(522, 21);
            this.rootFolderTextBox.TabIndex = 1;
            this.rootFolderTextBox.Click += new System.EventHandler(this.rootFolderTextBox_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 91);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FQMContent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(716, 393);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 3;
            // 
            // FQMContent
            // 
            this.FQMContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FQMContent.Controls.Add(this.folderFQMView);
            this.FQMContent.Location = new System.Drawing.Point(4, 4);
            this.FQMContent.Name = "FQMContent";
            this.FQMContent.Size = new System.Drawing.Size(274, 387);
            this.FQMContent.TabIndex = 0;
            this.FQMContent.TabStop = false;
            this.FQMContent.Text = "FQMContent";
            // 
            // folderFQMView
            // 
            this.folderFQMView.AllColumns.Add(this.statusColumnFQM);
            this.folderFQMView.AllColumns.Add(this.contentColumnFQM);
            this.folderFQMView.AllColumns.Add(this.countColumnFQM);
            this.folderFQMView.AllowDrop = true;
            this.folderFQMView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderFQMView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusColumnFQM,
            this.contentColumnFQM,
            this.countColumnFQM});
            this.folderFQMView.GridLines = true;
            this.folderFQMView.HeaderUsesThemes = false;
            this.folderFQMView.HideSelection = false;
            this.folderFQMView.HighlightBackgroundColor = System.Drawing.Color.Crimson;
            this.folderFQMView.HighlightForegroundColor = System.Drawing.Color.DarkGreen;
            this.folderFQMView.Location = new System.Drawing.Point(6, 18);
            this.folderFQMView.Name = "folderFQMView";
            this.folderFQMView.Size = new System.Drawing.Size(262, 364);
            this.folderFQMView.TabIndex = 0;
            this.folderFQMView.UseCompatibleStateImageBehavior = false;
            this.folderFQMView.View = System.Windows.Forms.View.Details;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.folderTreeView);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // folderTreeView
            // 
            this.folderTreeView.AllColumns.Add(this.treeColumnName);
            this.folderTreeView.AllColumns.Add(this.treeColumnMapping);
            this.folderTreeView.AllColumns.Add(this.treeColumnModify);
            this.folderTreeView.AllColumns.Add(this.treeColumnSize);
            this.folderTreeView.AllColumns.Add(this.treeColumnFileType);
            this.folderTreeView.AllColumns.Add(this.treeColumnFileExtension);
            this.folderTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTreeView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.folderTreeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.treeColumnName,
            this.treeColumnMapping,
            this.treeColumnModify,
            this.treeColumnSize,
            this.treeColumnFileType});
            this.folderTreeView.EmptyListMsg = "Empty Folder";
            this.folderTreeView.Location = new System.Drawing.Point(6, 18);
            this.folderTreeView.Name = "folderTreeView";
            this.folderTreeView.OverlayText.InsetX = 40;
            this.folderTreeView.OverlayText.Rotation = -90;
            this.folderTreeView.OverlayText.Text = "";
            this.folderTreeView.OwnerDraw = true;
            this.folderTreeView.ShowGroups = false;
            this.folderTreeView.Size = new System.Drawing.Size(415, 364);
            this.folderTreeView.TabIndex = 0;
            this.folderTreeView.UseCompatibleStateImageBehavior = false;
            this.folderTreeView.View = System.Windows.Forms.View.Details;
            this.folderTreeView.VirtualMode = true;
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
            // treeColumnFileExtension
            // 
            this.treeColumnFileExtension.AspectName = "Extension";
            this.treeColumnFileExtension.IsEditable = false;
            this.treeColumnFileExtension.IsVisible = false;
            this.treeColumnFileExtension.Text = "Extension";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidate.Location = new System.Drawing.Point(540, 7);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(90, 21);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(636, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 21);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save To ...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // countColumnFQM
            // 
            this.countColumnFQM.AspectName = "Present";
            this.countColumnFQM.Text = "Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxHideOptional);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.comboSubSegment);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // comboSubSegment
            // 
            this.comboSubSegment.FormattingEnabled = true;
            this.comboSubSegment.Items.AddRange(new object[] {
            "RMC",
            "CC",
            "SMS"});
            this.comboSubSegment.Location = new System.Drawing.Point(77, 20);
            this.comboSubSegment.Name = "comboSubSegment";
            this.comboSubSegment.Size = new System.Drawing.Size(87, 20);
            this.comboSubSegment.TabIndex = 0;
            this.comboSubSegment.SelectedIndexChanged += new System.EventHandler(this.comboSubSegment_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 12);
            this.label.TabIndex = 1;
            this.label.Text = "SubSegment";
            // 
            // checkBoxHideOptional
            // 
            this.checkBoxHideOptional.AutoSize = true;
            this.checkBoxHideOptional.Location = new System.Drawing.Point(170, 22);
            this.checkBoxHideOptional.Name = "checkBoxHideOptional";
            this.checkBoxHideOptional.Size = new System.Drawing.Size(102, 16);
            this.checkBoxHideOptional.TabIndex = 2;
            this.checkBoxHideOptional.Text = "Hide Optional";
            this.checkBoxHideOptional.UseVisualStyleBackColor = true;
            this.checkBoxHideOptional.CheckedChanged += new System.EventHandler(this.checkBoxHideOptional_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.rootFolderTextBox);
            this.Name = "MainForm";
            this.Text = "FQM Tool";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.FQMContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderFQMView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderTreeView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rootFolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog rootFolderBrowserDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox FQMContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private BrightIdeasSoftware.TreeListView folderTreeView;
        private System.Windows.Forms.Button buttonValidate;
        private BrightIdeasSoftware.ObjectListView folderFQMView;
        private BrightIdeasSoftware.OLVColumn treeColumnName;
        private BrightIdeasSoftware.OLVColumn treeColumnModify;
        private BrightIdeasSoftware.OLVColumn treeColumnSize;
        private BrightIdeasSoftware.OLVColumn treeColumnFileType;
        private BrightIdeasSoftware.OLVColumn treeColumnFileExtension;
        private BrightIdeasSoftware.OLVColumn contentColumnFQM;
        private System.Windows.Forms.Button buttonSave;
        private BrightIdeasSoftware.OLVColumn statusColumnFQM;
        private BrightIdeasSoftware.OLVColumn treeColumnMapping;
        private BrightIdeasSoftware.OLVColumn countColumnFQM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboSubSegment;
        private System.Windows.Forms.CheckBox checkBoxHideOptional;
    }
}

