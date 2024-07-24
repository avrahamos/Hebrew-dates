using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hebroDates.configuration
{
    internal class Appconfiguration
    {
        public static string HebrewDatePath = Path.Combine(Directory.GetCurrentDirectory(),
            " HebrewDatePath.xml");
    }
}
