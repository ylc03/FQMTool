using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FQM.Model
{
    /// <summary>
    /// Section
    /// </summary>
    class Section
    {
        /// <summary>
        /// Name of the section
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Order to place the section
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Similar name of the section, which will be recoginized as a section
        /// </summary>
        public List<string> SimilarNames { get; set; }

        /// <summary>
        /// collection of sub sections
        /// </summary>
        private List<SubSection> subSections = new List<SubSection>();
        public List<SubSection> SubSections
        {
            get 
            {
                return subSections;
            }
        }

        /// <summary>
        /// Validate if the name matches the section
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>true/false</returns>
        public bool ValidateSectionName(string name)
        {
            if (string.Compare(name, this.Name, true) == 0)
            {
                return true;
            }

            foreach (string sname in this.SimilarNames)
            {
                if (string.Compare(sname, this.Name, true) == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
