using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FQM.Model
{
    /// <summary>
    /// Job quality folder template.
    /// Folder Structure: 
    /// Folder ---- config.jqf (configuration file include the mapping from file to template)
    ///        |
    ///        |--- Section 01
    ///        |--- Section 02 ---- SubSection
    ///                        |--- SubSection ---- file, file
    ///                                        |--- folder, folder
    ///         ::: 
    ///        |--- Section 18..
    /// </summary>
    class Template
    {
        protected List<Section> sections;
        /// <summary>
        /// Template sections, always fixed.
        /// </summary>
        public List<Section> Sections 
        { 
            get 
            {
                return sections;
            } 
        }

        /// <summary>
        /// Template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Add default 18 sections to the class
        /// </summary>
        public Template()
        {
            this.sections = new List<Section>
            {
                new Section 
                {
                        Name = "Section 01 Quality Control Plan", 
                        Order = 1, 
                        SimilarNames = new List<string>
                        {
                            "Section 1 Quality Control Plan",
                            "Quality Control Plan",
                            "QCP"
                        }
                },
                new Section 
                {
                        Name = "Section 02 Well Information", 
                        Order = 2, 
                        SimilarNames = new List<string>
                        {
                            "Section 2 Well Information",
                            "Well Information"
                        }
                },
                new Section 
                {
                        Name = "Section 03 Well Schematics", 
                        Order = 3, 
                        SimilarNames = new List<string>
                        {
                            "Section 3 Well Schematics",
                            "Well Schematics"
                        }
                },
                new Section 
                {
                        Name = "Section 04 Procedures", 
                        Order = 4, 
                        SimilarNames = new List<string>
                        {
                            "Section 4 Procedures",
                            "Procedures"
                        }
                },new Section 
                {
                        Name = "Section 05 Pipe & Tubing Info", 
                        Order = 5, 
                        SimilarNames = new List<string>
                        {
                            "Section 5 Pipe & Tubing Info",
                            "Pipe & Tubing Info"
                        }
                },
                new Section 
                {
                        Name = "Section 06 Engineering and Fishing Diagrams", 
                        Order = 6, 
                        SimilarNames = new List<string>
                        {
                            "Section 6 Engineering and Fishing Diagrams",
                            "Engineering and Fishing Diagrams"
                        }
                },
                new Section 
                {
                        Name = "Section 07 Job Calculations", 
                        Order = 7, 
                        SimilarNames = new List<string>
                        {
                            "Section 7 Job Calculations",
                            "Job Calculations"
                        }
                },
                new Section 
                {
                        Name = "Section 08 Sub Assembly and Equipment Make up Charts", 
                        Order = 8, 
                        SimilarNames = new List<string>
                        {
                            "Section 8 Sub Assembly and Equipment Make up Charts",
                            "Sub Assembly and Equipment Make up Charts"
                        }
                },new Section 
                {
                        Name = "Section 09 Equipment Lists, Load out and Backload lists", 
                        Order = 9, 
                        SimilarNames = new List<string>
                        {
                            "Section 09 Equipment Lists, Load out and Backload lists",
                            "Equipment Lists, Load out and Backload lists"
                        }
                },
                new Section 
                {
                        Name = "Section 10 Sales Items Certificates and Test Data", 
                        Order = 10, 
                        SimilarNames = new List<string>
                        {
                            "Sales Items Certificates and Test Data"
                        }
                },
                new Section 
                {
                        Name = "Section 11 Service Equipment RITE information", 
                        Order = 11, 
                        SimilarNames = new List<string>
                        {
                            "Service Equipment RITE information"
                        }
                },
                new Section 
                {
                        Name = "Section 12 Handling Equipment Certificates", 
                        Order = 12, 
                        SimilarNames = new List<string>
                        {
                            "Handling Equipment Certificates"
                        }
                },
                new Section 
                {
                        Name = "Section 13 QHSE, QUEST and Intouch", 
                        Order = 13, 
                        SimilarNames = new List<string>
                        {
                            "QHSE, QUEST and Intouch"
                        }
                },
                new Section 
                {
                        Name = "Section 14 Job Execution(Wellsite Reports)", 
                        Order = 14, 
                        SimilarNames = new List<string>
                        {
                            "Job Execution(Wellsite Reports)",
                            "Job Execution",
                            "Wellsite Reports"
                        }
                },new Section 
                {
                        Name = "Section 15 Field Ticket", 
                        Order = 15, 
                        SimilarNames = new List<string>
                        {
                            "Field Ticket"
                        }
                },
                new Section 
                {
                        Name = "Section 16 End of Well Report", 
                        Order = 16, 
                        SimilarNames = new List<string>
                        {
                            "End of Well Report"
                        }
                },
                new Section 
                {
                        Name = "section 17 Meeting minutes", 
                        Order = 17, 
                        SimilarNames = new List<string>
                        {
                            "Meeting minutes"
                        }
                },
                new Section 
                {
                        Name = "Section 18 Miscellaneous", 
                        Order = 18, 
                        SimilarNames = new List<string>
                        {
                            "Miscellaneous"
                        }
                }
            };
        }
    }
}
