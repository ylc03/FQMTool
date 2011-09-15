using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FQM.Model
{
    class RootPathChangeEventArg : EventArgs
    {
        public string Root { get; set; }
        public string OldRoot { get; set; }
    }

    class TemplateChangeEventArg : EventArgs
    {
        public string NewTemplate { get; set; }
        public string OldTemplate { get; set; }
    }

    class InvalidRootPathException : Exception
    {
        public InvalidRootPathException(string root)
        {
            this.RootPath = root;
        }

        public string RootPath
        {
            get;
            set;
        }
    }

    class JobQualityFolder : IDisposable
    {
        private Dictionary<string, SubSection> mapping = new Dictionary<string, SubSection>();
        private Template folderTemplate;

        public const string POSTFIX = "jqf";
        public const string CONFIG_FILENAME = "config" + "." + JobQualityFolder.POSTFIX;

        public JobQualityFolder(string rootPath)
        {
            this.RootPath = rootPath;
            this.Load();
        }

        #region properties

        private DirectoryInfo rootPath;
        private string configFile;
        public string RootPath
        {
            get
            {
                if (IsRootPathValid)
                {
                    return rootPath.FullName;
                }

                return null;
            }
            set
            {
                if (!this.validateRootPath(value))
                {
                    throw new InvalidRootPathException(value);
                }

                DirectoryInfo newRoot = new DirectoryInfo(value);
                if (this.rootPath == null || string.Compare(this.rootPath.FullName, newRoot.FullName, true) != 0)
                {
                    string oldRootName = this.rootPath == null ? "" : this.rootPath.FullName;
                    this.rootPath = newRoot;
                    this.configFile = newRoot.FullName + Path.DirectorySeparatorChar + JobQualityFolder.CONFIG_FILENAME;
                    RaiseRootPathChangeEvent(this, new RootPathChangeEventArg { OldRoot = oldRootName, Root = newRoot.FullName });
                }
            }
        }

        public bool IsRootPathValid
        {
            get
            {
                return this.validateRootPath(this.RootPath);
            }
        }

        public bool IsDirty
        {
            get;
            set;
        }

        #endregion

        #region events

        public event EventHandler<RootPathChangeEventArg> OnRootPathChange;
        public event EventHandler<TemplateChangeEventArg> OnTemplateChange;

        private void RaiseRootPathChangeEvent(object sender, RootPathChangeEventArg arg)
        {
            if (OnRootPathChange != null)
            {
                OnRootPathChange(sender, arg);
            }
        }

        private void RaiseTemplateChangeEvent(object sender, TemplateChangeEventArg arg)
        {
            if (OnTemplateChange != null)
            {
                OnTemplateChange(sender, arg);
            }
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            OnRootPathChange = null;
            OnTemplateChange = null;
        }

        #endregion

        public void Save()
        {

        }

        public void SaveAs(string folder)
        {
            //TODO: save everything in new folder

            this.RootPath = folder;
        }

        public void Load()
        {

        }

        public void Clear()
        {
            this.mapping.Clear();
        }

        /// <summary>
        /// Remove file/folder in the mapping
        /// </summary>
        /// <param name="fs"></param>
        public void RemoveMapping(FileSystemInfo fs)
        {
            if (MappingExists(fs))
            {
                if (fs is FileInfo)
                {
                    File.Delete(fs.FullName);
                }
                else
                {
                    Directory.Delete(fs.FullName);
                }
                this.mapping.Remove(fs.FullName);
            }
        }

        /// <summary>
        /// Add file/folder to sub sections
        /// If subSection is null or not found, the fs will be added to default place. (Section 18 Miscellaneous)
        /// </summary>
        /// <param name="subSection">subSection to put the file/folder in</param>
        /// <param name="fs">File System info</param>
        public void AddMapping(SubSection subSection, FileSystemInfo fs)
        {
            if (!MappingExists(fs))
            {
                string mappedPath = this.RootPath + Path.DirectorySeparatorChar
                                  + subSection.FolderName + Path.DirectorySeparatorChar
                                  + fs.Name;
                if (fs is DirectoryInfo)
                {
                    FileSystemUtility.CopyDirectory(fs.FullName, mappedPath, false);
                    DirectoryInfo newInfo = new DirectoryInfo(mappedPath);

                    this.mapping[newInfo.FullName] = subSection;
                }
                else
                {
                    FileSystemUtility.CopyFile(fs.FullName, mappedPath, false);
                    FileInfo newInfo = new FileInfo(mappedPath);

                    this.mapping[newInfo.FullName] = subSection;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fs"></param>
        /// <returns></returns>
        public bool MappingExists(FileSystemInfo fs)
        {
            return this.mapping.Keys.Contains(fs.FullName);
        }

        private bool validateRootPath(string root)
        {
            if (Directory.Exists(root))
            {
                return true;
            }

            return false;
        }

        public static bool ValidateRootPath(string root)
        {
            if (Directory.Exists(root))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(root);
                if (dirInfo.GetFileSystemInfos().Length == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
