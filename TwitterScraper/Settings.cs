using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterScraper
{
    [Serializable]
    public class Settings
    {
        internal string UserAgent;
        internal string RequestTimeout;
        internal string Threads;
        internal string Proxy;
        internal string OutputDirectory;
        internal string CsvDelimiter;
        internal bool DumpDebugData;
    }
}
