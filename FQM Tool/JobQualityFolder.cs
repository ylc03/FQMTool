using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FQM
{
    public class ContentMapping
    {
        public int Section { get; set; }
        public String Content { get; set; }
        public int Present {get; set;}
        public bool RMC { get; set; }
        public bool CC { get; set; }
        public bool SMS { get; set; }

        public ContentMapping() { }

        public ContentMapping(int section, String content, bool rmc, bool sms, bool cc, int present = 0 )
        {
            this.Section = section;
            this.Content = content;
            this.Present = present;
            this.RMC = rmc;
            this.SMS = sms;
            this.CC = cc;
        }

        public String SectionName
        {
            get
            {
                return JobQualityFolder.sectionNames[this.Section - 1];
            }
        }
    }

    public class ContentMappingStructEditor : ComboBox
    {
        public ContentMappingStructEditor()
        {
            foreach(ContentMapping map in JobQualityFolder.ContentMapping)
            {
                this.Items.Add(map.Content);
            }
        }
    }

    public class JobQualityFolder
    {
        private String jobFolder;

        public static String[] sectionNames = new String[] {
            "Section 01 Quality Control Plan",
            "Section 02 Well Information",
            "Section 03 Well Schematics",
            "Section 04 Procedures",
            "Section 05 Pipe & Tubing Info",
            "Section 06 Engineering and Fishing Diagrams",
            "Section 07 Job Calculations",
            "Section 08 Sub Assembly and Equipment Make up Charts",
            "Section 09 Equipment Lists, Load out and Backload lists",
            "Section 10 Sales Items Certificates and Test Data",
            "Section 11 Service Equipment RITE information",
            "Section 12 Handling Equipment Certificates",
            "Section 13 QHSE, QUEST and Intouch",
            "Section 14 Job Execution(Wellsite Reports)",
            "Section 15 Field Ticket",
            "Section 16 End of Well Report",
            "section 17 meeting minutes",
            "Section 18 Miscellaneous",
        };

        public static ContentMapping[] ContentMapping = new ContentMapping[]
        {
            new ContentMapping(1, "KSQR",                         true,   true,   true),
            new ContentMapping(1, "Check lists",                  false,  true,   false),
            new ContentMapping(1, "Service delivery plan",        true,   false,  false),

            new ContentMapping(2, "Well Specifications",          true,   false,  false),
            new ContentMapping(2, "Client submitted schematic",   false,  false,  false),
            new ContentMapping(2, "Well history",                 false,  false,  false),
            new ContentMapping(2, "Operations overview",          false,  false,  false),
            new ContentMapping(2, "Well survey",                  false,  false,  false),
            new ContentMapping(2, "Reservoir Info",               false,  false,  false),

            new ContentMapping(3, "Well Schematic - SLB",         false,  true,   true ),
            new ContentMapping(3, "Final Schematic",              true,   true,   true ),

            new ContentMapping(4, "Client well program",          true,   true,   true ),
            new ContentMapping(4, "SLB operating procedure",      false,  true,   true ),

            new ContentMapping(5, "Tubular data & info",          false,  false,  false),
            new ContentMapping(5, "Tubing Tally",                 true,   true,   true ),

            new ContentMapping(6, "Engineering Data",             false,  true,   true ),
            new ContentMapping(6, "Fishing Drawing",              false,  true,   true ),

            new ContentMapping(7, "Any Calculations",             false,  true,   false),
            new ContentMapping(7, "TDAS Simulation",              false,  true,   false),

            new ContentMapping(8, "Assembly certificates",        true,   true,   true ),
            new ContentMapping(8, "Torque charts",                true,   true,   true ),

            new ContentMapping(9, "Sales Items",                              true,   true,   true ),
            new ContentMapping(9, "Service/rental equipments list",           false,  false,  false),
            new ContentMapping(9, "Load out list",                            true,   true,   false),
            new ContentMapping(9, "Backload list",                            false,  true,   false),

            new ContentMapping(10, "Sales items certificates, T& I sheets",   false,  false,  false),
            new ContentMapping(10, "Manufacturing QP",                        false,  false,  false),

            new ContentMapping(11, "Rite FIT sheets",                         true,   false,  false),
            new ContentMapping(11, "Certificates for 3rd parties equipments", true,   false,  false),

            new ContentMapping(12, "Handling equipments certificates",        false,  false,  false),

            new ContentMapping(13, "HARCs",                                   false,  true,   true ),            
            new ContentMapping(13, "QUEST Reports",                           true,   true,   false),            
            new ContentMapping(13, "InTouch ticket & contents",               false,  false,  false),            
            new ContentMapping(13, "Job Site Audits (JSA)",                   false,  false,  false),            
            new ContentMapping(13, "Service Quality events and non-conformance investigation data",   
                                                                                    false,  false,  false),       
     
            new ContentMapping(14, "Job daily rig reports",                   true,   true,   true ),
            new ContentMapping(14, "Job service reports",                     true,   true,   true ),
            new ContentMapping(14, "Wellsite acquisition reports",            true,   false,  false),
            new ContentMapping(14, "Client satisfaction reports",             true,   true,   true ),
            new ContentMapping(14, "Any others well site reports",            true,   false,  false),

            new ContentMapping(15, "Final Field Ticket For The Job",          true,   false,  false),

            new ContentMapping(16, "Documented EOWR",                         true,   false,  false),

            new ContentMapping(17, "All meetings for the job",                true,   true,   true ),

            new ContentMapping(18, "All job related data not covered in above sections",          
                                                                                    true,   false,  false),
            new ContentMapping(18, "Job Preparation and Job Execution Organigrams",          
                                                                                    false,  false,  false),
            new ContentMapping(18, "Improvement comments and notes",          false,  false,  false),

        };

        // contructor
        public JobQualityFolder(String folder)
        {
            this.jobFolder = folder;  
        }

        // validate if the folder is compliant with Job Quality Folder
        public bool Validate(String folder)
        {
            return true;
        }

        public bool Validate()
        {
            return Validate(this.jobFolder);
        }

        public void save()
        { 
          
        }
    }
}
