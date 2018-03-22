using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Feeds.Views.Home
{
    /// <summary>
    /// Class for getting rss data from url.
    /// </summary>
    public class RssGetData : RssVariables
    {
        //Datasource
        private string RssUrl = "https://flipboard.com/@raimoseero/feed-nii8kd0sz?rss";

        /// <summary>
        /// Get rss data from url
        /// </summary>
        /// <returns></returns>
        public List<RssVariables> GetData()
        {
            XDocument xdoc = XDocument.Load(RssUrl);

            List<RssVariables> ElementLists = (from item in xdoc.Descendants("item")
                                               select new RssVariables
                                               {
                                                   //Detail1 = (string)detail.Attribute("id") ?? "No id",
                                                   Variable1 = ((string)item.Element("title")).RemoveEntity() ?? String.Empty,
                                                   Variable2 = (string)item.Element("link") ?? String.Empty,

                                                   Variable3 = (string)item.Element(XmlnsMedia + "content") != null ?
                                                   (string)item.Element(XmlnsMedia + "content").Attribute("url") : String.Empty,

                                                   Variable4 = ((string)item.Element("category")).RemoveEntity() ?? String.Empty,
                                                   Variable5 = (string)item.Element("category") != null ?
                                                   ((string)item.Element("category").Attribute("domain")) : String.Empty,

                                                   Variable6 = ((string)item.Element("description")).RemoveEntity() ?? String.Empty,
                                                   Variable7 = ((string)item.Element("pubDate")).RemoveEntity() ?? String.Empty,
                                                   Variable8 = ((string)item.Element("author")).RemoveEntity() ?? String.Empty
                                               }).ToList();
            return ElementLists;
        }
    }
}


