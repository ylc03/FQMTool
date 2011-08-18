﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FQM.Model
{
    class RootPathChangeEventArg : EventArgs
    {
        public string NewRoot { get; set; }
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

        public static const string POSTFIX = "jqf";
        public static const string CONFIG_FILENAME = "config" + "." + JobQualityFolder.POSTFIX;

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
                if (!this.ValidateRootPath(value))
                {
                    throw new InvalidRootPathException(value);
                }

                DirectoryInfo newRoot = new DirectoryInfo(value);
                if (string.Compare(this.rootPath.FullName, newRoot.FullName, true) != 0)
                {
                    DirectoryInfo oldRoot = rootPath;
                    rootPath = newRoot;
                    configFile = newRoot.FullName + Path.DirectorySeparatorChar + JobQualityFolder.CONFIG_FILENAME;
                    RaiseRootPathChangeEvent(this, new RootPathChangeEventArg { OldRoot = oldRoot.FullName, NewRoot = newRoot.FullName });
                }
            }
        }

        public bool IsRootPathValid
        {
            get
            {
                return this.ValidateRootPath(this.RootPath);
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

        private bool ValidateRootPath(string root)
        {
            if (Directory.Exists(root))
            {
                return true;
            }

            return false;
        }
    }
}