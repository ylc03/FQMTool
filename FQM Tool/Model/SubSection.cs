using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FQM.Model
{
    class SubSection
    {
        public Section Section { get; set; }

        public string Name { get; set; }

        public bool HasFolder { get; set; }

        public bool IsRequired { get; set; }

        public string FolderName
        {
            get
            {
                if (this.Section == null) return null;

                string folderName = Section.Name;
                if (this.HasFolder)
                {
                    folderName += Path.DirectorySeparatorChar;
                    folderName += this.Name;
                }

                return folderName;
            }
        }
    }
}
