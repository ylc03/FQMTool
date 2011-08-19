using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using BrightIdeasSoftware;
using System.Drawing.Drawing2D;

namespace FQM
{
    public partial class MainForm : Form
    {
        private Dictionary<string, ContentMapping> fileMapping = new Dictionary<string, ContentMapping>();

        public MainForm()
        {
            InitializeComponent();
            // local init functions
            InitializeFolderTreeView();
            InitializeFolderFQMView();

            this.comboSubSegment.SelectedIndex = 0;
        }

        private void InitializeFolderFQMView()
        {
            this.folderFQMView.AddObjects(JobQualityFolder.ContentMapping);
            this.contentColumnFQM.GroupKeyGetter = delegate (object rowObject)
            {
                ContentMapping content = (ContentMapping)rowObject;
                return content.SectionName;
            };

            this.statusColumnFQM.AspectGetter = delegate(object rowObject)
            {
                ContentMapping content = (ContentMapping)rowObject;
                if (content.Present > 0) return "YES"; // presented
                switch (this.comboSubSegment.Text) // must have
                { 
                    case "RMC":
                        if (content.RMC) return "NEED";
                        break;
                    case "CC":
                        if (content.CC) return "NEED";
                        break;
                    case "SMS":
                        if (content.SMS) return "NEED";
                        break;
                }
                return "IGNORE"; // ignore
            };
            this.statusColumnFQM.Renderer = new MappedImageRenderer(new object[] {"YES", Resource.Check, "NEED", Resource.Warning});
            
            this.folderFQMView.OwnerDraw = true;
            this.folderFQMView.BuildGroups(this.contentColumnFQM, SortOrder.Ascending);

        }

        private void InitializeFolderTreeView()
        {
            this.folderTreeView.CanExpandGetter = delegate(object x)
            {
                return (x is DirectoryInfo);
            };
            this.folderTreeView.ChildrenGetter = delegate(object x)
            {
                DirectoryInfo dir = (DirectoryInfo)x;
                try
                {
                    return new ArrayList(dir.GetFileSystemInfos());

                    // Test checking objects before they exist in the list

                    //ArrayList list = new ArrayList(dir.GetFileSystemInfos());
                    //ArrayList list2 = new ArrayList();
                    //foreach (FileSystemInfo fsi in list) {
                    //    if (fsi.Name.ToLowerInvariant().StartsWith("d"))
                    //        list2.Add(fsi);
                    //}
                    //this.treeListView.CheckedObjects = list2;
                    //return list;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(this, ex.Message, "FQM Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return new ArrayList();
                }
            };

            this.folderTreeView.CheckBoxes = false;

            // You can change the way the connection lines are drawn by changing the pen
            TreeListView.TreeRenderer renderer = (TreeListView.TreeRenderer)this.folderTreeView.TreeColumnRenderer;
            renderer.LinePen = new Pen(Color.Blue, 0.5f);
            renderer.LinePen.DashStyle = DashStyle.Dot;

            //-------------------------------------------------------------------
            // Eveything after this is the same as the Explorer example tab --
            // nothing specific to the TreeListView. It doesn't have the grouping
            // delegates, since TreeListViews can't show groups.

            // Draw the system icon next to the name
            SysImageListHelper helper = new SysImageListHelper(this.folderTreeView);
            this.treeColumnName.ImageGetter = delegate(object x)
            {
                return helper.GetImageIndex(((FileSystemInfo)x).FullName);
            };

            // Show the size of files as GB, MB and KBs. Also, group them by
            // some meaningless divisions
            this.treeColumnSize.AspectGetter = delegate(object x)
            {
                if (x is DirectoryInfo)
                    return (long)-1;

                try
                {
                    return ((FileInfo)x).Length;
                }
                catch (System.IO.FileNotFoundException)
                {
                    // Mono 1.2.6 throws this for hidden files
                    return (long)-2;
                }
            };
            this.treeColumnSize.AspectToStringConverter = delegate(object x)
            {
                if ((long)x == -1) // folder
                    return "";
                else
                    return this.FormatFileSize((long)x);
            };

            // Show the system description for this object
            this.treeColumnFileType.AspectGetter = delegate(object x)
            {
                return ShellUtilities.GetFileType(((FileSystemInfo)x).FullName);
            };

            // treeColumnMapping setting
            this.treeColumnMapping.AspectGetter = delegate(object x)
            {
                FileSystemInfo file = (FileSystemInfo)x;
                if (fileMapping.ContainsKey(file.FullName))
                {
                    return fileMapping[file.FullName];
                }
                return new ContentMapping();
            };

            this.treeColumnMapping.AspectToStringConverter = delegate(object x)
            {
                ContentMapping mapping = (ContentMapping)x;
                return mapping.Content;
            };

            // treeColumnMapping editor
            ObjectListView.EditorRegistry.Register(typeof(ContentMapping), typeof(ContentMappingStructEditor));
            folderTreeView.CellEditStarting += new CellEditEventHandler(folderTreeView_CellEditStarting);
            folderTreeView.CellEditFinishing += new CellEditEventHandler(folderTreeView_CellEditFinishing);
        }

        void folderTreeView_CellEditStarting(object sender, CellEditEventArgs e)
        {
            FileSystemInfo file = (FileSystemInfo)e.RowObject;
            ContentMappingStructEditor editor = (ContentMappingStructEditor) e.Control;

            if (editor is ContentMappingStructEditor)
            {
                if (this.fileMapping.ContainsKey(file.FullName))
                {
                    editor.SelectedText = this.fileMapping[file.FullName].Content;
                }
            }
        }

        void folderTreeView_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            ContentMappingStructEditor editor = (ContentMappingStructEditor)e.Control;
            FileSystemInfo file = (FileSystemInfo)e.RowObject;
            ContentMapping map = null;

            if (editor is ContentMappingStructEditor)
            {
                if (this.fileMapping.ContainsKey(file.FullName))
                {
                    this.fileMapping[file.FullName].Present -= 1;
                    this.folderFQMView.RefreshObject(this.fileMapping[file.FullName]);
                    this.fileMapping.Remove(file.FullName);
                }

                if (editor.Items.Contains(editor.Text))
                {
                    map = JobQualityFolder.ContentMapping[editor.Items.IndexOf(editor.Text)];
                    this.fileMapping[file.FullName] = map;
                    map.Present += 1;
                    this.folderFQMView.RefreshObject(map);
                }

                // update views
                this.folderTreeView.RefreshItem(e.ListViewItem);
            }
        }

        private string FormatFileSize(long size)
        {
            int[] limits = new int[] { 1024 * 1024 * 1024, 1024 * 1024, 1024 };
            string[] units = new string[] { "GB", "MB", "KB" };

            for (int i = 0; i < limits.Length; i++)
            {
                if (size >= limits[i])
                    return String.Format("{0:#,##0.##} " + units[i], ((double)size / limits[i]));
            }

            return String.Format("{0} bytes", size);
        }

        private void buttonChooseRootFolder_Click(object sender, EventArgs e)
        {
            rootFolderBrowserDialog.ShowDialog();
            rootFolderTextBox.Text = rootFolderBrowserDialog.SelectedPath;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            // List all drives as the roots of the tree
            this.folderTreeView.ClearObjects();
            this.fileMapping.Clear();

            if (!Directory.Exists(this.rootFolderTextBox.Text))
            {
                MessageBox.Show("Folder doesn't exists!", "Warning");
                return;
            }

            DirectoryInfo root_dir = new DirectoryInfo(this.rootFolderTextBox.Text);
            this.folderTreeView.Roots = root_dir.GetFileSystemInfos();
            foreach (FileSystemInfo fi in this.folderTreeView.Roots)
            {
                this.folderTreeView.Expand(fi);
            }
        }

        private void rootFolderTextBox_Click(object sender, EventArgs e)
        {
            this.rootFolderBrowserDialog.ShowDialog();

            this.rootFolderTextBox.Text = this.rootFolderBrowserDialog.SelectedPath;
        }

        private void comboSubSegment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.folderFQMView.ClearObjects();
            this.folderFQMView.AddObjects(JobQualityFolder.ContentMapping);
            this.checkBoxHideOptional_CheckedChanged(null, null);
        }

        private void checkBoxHideOptional_CheckedChanged(object sender, EventArgs e)
        {
            List<ContentMapping> hideMappings = new List<ContentMapping>();
            foreach (ContentMapping map in JobQualityFolder.ContentMapping)
            {
                switch (this.comboSubSegment.Text)
                {
                    case "RMC":
                        if (map.RMC == false) hideMappings.Add(map);
                        break;
                    case "CC":
                        if (map.CC == false) hideMappings.Add(map);
                        break;
                    case "SMS":
                        if (map.SMS == false) hideMappings.Add(map);
                        break;
                }
            }

            this.folderFQMView.RemoveObjects(hideMappings);
            if (this.checkBoxHideOptional.Checked == false)
            {
                this.folderFQMView.AddObjects(hideMappings);
            }
            this.folderFQMView.BuildGroups(this.contentColumnFQM, SortOrder.Ascending);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
