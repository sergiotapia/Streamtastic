using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using Streamtastic.Abstract;
using Streamtastic.Helpers;
using Streamtastic.Models;

namespace Streamtastic.Concrete
{
    public class Own3dStreamRepository : IStreamRepository
    {
        public List<StreamModel> FindTopViewedStreams()
        {
            //http://www.own3d.tv/live
            var topStreams = new List<StreamModel>();
            
            string url = "http://www.own3d.tv/live";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(url);
            var html = htmlDoc.DocumentNode;

            var container = html.CssSelect("#top_live").First();
            var streams = container.Descendants("div")
                                   .Where(div => div.GetAttributeValue("class", "").Contains("VIDEOS-1grid-box"));

            foreach (var stream in streams)
            {
                //Let's build out the Own3d model.
                StreamModel model = new StreamModel();
                model.Title = stream.CssSelect("a.small_tn_title_live").First().InnerText.Trim();
                model.ChannelUrl = "http://www.own3d.tv" + stream.CssSelect("a.small_tn_title_live").First().GetAttributeValue("href", "");
                model.ChannelOwner = stream.CssSelect("a.small_tn_info").ToList()[1].InnerText.Trim();
                model.ViewerCount = SanitizeHelper.SanitizeViewCount(stream.CssSelect("span.small_tn_viewers").First().InnerText);
                model.ThumbnailPreviewUrl = stream.CssSelect("img.previewTN").First().GetAttributeValue("src", "");

                topStreams.Add(model);
            }

            return topStreams;
        }
    }
}
