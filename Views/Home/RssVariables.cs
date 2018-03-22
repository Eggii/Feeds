
using System.Xml.Linq;

namespace Feeds.Views.Home
{
    /// <summary>
    /// Class for holding RSS variables
    /// </summary>
    public class RssVariables
    {
        private XNamespace _xmlMedia = "http://search.yahoo.com/mrss/";

        public XNamespace XmlnsMedia { get => _xmlMedia; }
        public string Variable1 { get; set; }
        public string Variable2 { get; set; }
        public string Variable3 { get; set; }
        public string Variable4 { get; set; }
        public string Variable5 { get; set; }
        public string Variable6 { get; set; }
        public string Variable7 { get; set; }
        public string Variable8 { get; set; }
        public string Variable9 { get; set; }
    }
}