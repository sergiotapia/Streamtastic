using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using Streamtastic.Abstract;
using Streamtastic.Models;

namespace Streamtastic.Concrete
{
    public class TwitchtvStreamRepository : IStreamRepository
    {
        public List<StreamModel> FindTopViewedStreams()
        {
            string apiEndpoint = "http://api.justin.tv/api/stream/list.xml?category=gaming";

            var topStreams = new List<StreamModel>();
            var xmlDocument = XDocument.Load(apiEndpoint);

            var streams = (from stream in xmlDocument.Descendants("stream")
                           select new StreamModel()
                                      {
                                          Title = stream.Element("title").Value,
                                          ViewerCount = Convert.ToInt32(stream.Element("channel_count").Value),
                                          ChannelOwner = stream.Element("channel").Element("login").Value,
                                          ThumbnailPreviewUrl = Helpers.SanitizeHelper.SanitizeThumbnailUrlTwitchtv(stream.Element("channel").Element("screen_cap_url_medium").Value, stream.Element("channel").Element("login").Value),
                                          ChannelUrl = stream.Element("channel").Element("channel_url").Value
                                      }).ToList<StreamModel>();

            return streams;
        }

        public List<StreamModel> FindTopViewedStreamsByGame(string gameName)
        {
            string url = String.Format("http://www.twitch.tv/directory/{0}", gameName);

            var topStreams = new List<StreamModel>();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(url);
            var html = htmlDoc.DocumentNode;

            var container = html.CssSelect("div.video_grid").First();
            var streamElements = container.CssSelect("div.video");

            foreach (var streamElement in streamElements)
            {
                StreamModel streamModel = new StreamModel();
                streamModel.Title = streamElement.CssSelect("p.title").First().InnerText;
                streamModel.ChannelOwner = streamElement.CssSelect("p.channelname > a").First().InnerText;
                streamModel.ViewerCount = Convert.ToInt32(streamElement.CssSelect("span.channel_count").First().InnerText.Replace(",", ""));
                streamModel.ThumbnailPreviewUrl = Helpers.SanitizeHelper.SanitizeThumbnailUrlTwitchtv(streamElement.CssSelect("img.cap").First().GetAttributeValue("src", ""), streamModel.ChannelOwner);
                streamModel.ChannelUrl = "http://www.twitch.tv" + streamElement.CssSelect("a.thumb").First().GetAttributeValue("href", "");

                topStreams.Add(streamModel);
            }
            return topStreams;
        }
    }
}
