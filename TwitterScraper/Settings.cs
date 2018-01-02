using System;

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
