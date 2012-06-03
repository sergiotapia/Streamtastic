using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
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
                                          ThumbnailPreviewUrl = stream.Element("channel").Element("screen_cap_url_medium").Value,
                                          ChannelUrl = stream.Element("channel").Element("channel_url").Value,
                                          ChannelOwner = stream.Element("channel").Element("login").Value,
                                      }).ToList<StreamModel>();

            return streams;
        }

        public List<StreamModel> FindTopViewedStreamsByGame(string gameName)
        {
            string apiEndpoint = "http://api.justin.tv/api/stream/list.xml?category=gaming";

            var topStreams = new List<StreamModel>();
            var xmlDocument = XDocument.Load(apiEndpoint);

            var streams = (from stream in xmlDocument.Descendants("stream")
                           where stream.Element("meta_game") != null && stream.Element("meta_game").Value == gameName
                           select new StreamModel()
                           {
                               Title = stream.Element("title").Value,
                               ViewerCount = Convert.ToInt32(stream.Element("channel_count").Value),
                               ThumbnailPreviewUrl = stream.Element("channel").Element("screen_cap_url_medium").Value,
                               ChannelUrl = stream.Element("channel").Element("channel_url").Value,
                               ChannelOwner = stream.Element("channel").Element("login").Value,
                           }).ToList<StreamModel>();

            return streams;
        }
    }
}
