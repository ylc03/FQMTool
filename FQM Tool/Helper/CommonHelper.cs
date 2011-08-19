using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FQM.Helper
{
    class CommonHelper
    {
        public static string GetSystemUser()
        {
            return Environment.UserName;
        }

        public static string GetSystemDomain()
        {
            return Environment.UserDomainName;
        }

        public static string GetMachineName()
        {
            return Environment.MachineName;
        }

        public static string Now()
        {
            return DateTime.Now.ToString("MM/dd/yyyy H:mm:ss zzz");
        }
    }
}
