using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using Microsoft.Phone.Controls;
using System.Collections.Generic;

namespace SnowSlideWarning
{
    public class DataManager
    {
        private HtmlDocument doc;
        private WebBrowser browser;

        public DataManager()
        {
            this.doc = new HtmlDocument();
            this.browser = new WebBrowser();
        }

        public List<String> GetData(string url)
        {
            this.browser.Navigate(new Uri(url));
            doc.Load(this.browser.SaveToString());

            string bloc = doc.DocumentNode.SelectSingleNode("//body").SelectSingleNode("//div[@class='bloc_enneigement']").InnerHtml;
            HtmlDocument bloch = new HtmlDocument();
            bloch.LoadHtml(bloc);

            List<String> listInfo = new List<string>();
            foreach (HtmlNode p in bloch.DocumentNode.SelectNodes("//div"))
            {
                if (p.InnerText.Trim().Length > 93)
                {
                    listInfo.Add(p.InnerText.Trim().Substring(0, 55).Trim());
                    listInfo.Add(p.InnerText.Trim().Substring(55, p.InnerText.Trim().Length - 55).Trim());
                }
                else if (p.InnerText.Trim().Length > 35)
                {
                    listInfo.Add(p.InnerText.Trim().Substring(0, 35).Trim());
                    listInfo.Add(p.InnerText.Trim().Substring(35, p.InnerText.Trim().Length - 35).Trim());
                }
                else
                    listInfo.Add(p.InnerText.Trim());
            }
            return listInfo;
        }
    }
}
