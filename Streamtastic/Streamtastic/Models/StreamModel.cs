using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Streamtastic.Models
{
    public class StreamModel
    {
        public string Title { get; set; }

        public string ChannelOwner { get; set; }

        public string ChannelUrl { get; set; }

        public string ThumbnailPreviewUrl { get; set; }

        public int ViewerCount { get; set; }

    }
}