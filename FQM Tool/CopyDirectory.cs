using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FQM
{
    public static class FileSystemUtility
    {
        public static void CopyDirectory(string sourceFolderName, string destFolderName, bool overwrite = false)
        {
            if (File.Exists(sourceFolderName))
            {
                return;
            }

            if (destFolderName[destFolderName.Length-1] != Path.DirectorySeparatorChar)
            {
                destFolderName += Path.DirectorySeparatorChar;
            }

            if (!Directory.Exists(destFolderName))
            {
                Directory.CreateDirectory(destFolderName);
            }

            if (Directory.Exists(sourceFolderName))
            {
                string[] entries = Directory.GetFileSystemEntries(sourceFolderName);
                foreach (string entry in entries)
                {
                    if (Directory.Exists(entry))
                    {
                        CopyDirectory(entry, destFolderName + Path.GetDirectoryName(entry), overwrite);
                    }
                    else
                    {
                        CopyFile(entry, destFolderName + Path.GetFileName(entry), overwrite);
                    }
                }
            }
        }

        public static void CopyFile(string sourceFileName, string destFileName, bool overwrite = false)
        {
            if (File.Exists(sourceFileName))
            {
                File.Copy(sourceFileName, destFileName, overwrite);
            }
        }
    }
}
