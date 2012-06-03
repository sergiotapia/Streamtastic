using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Streamtastic.Abstract;
using Streamtastic.Models;

namespace Streamtastic.Concrete
{
    public class Own3dStreamRepository : IStreamRepository
    {
        public List<StreamModel> FindTopViewedStreams()
        {
            //http://www.own3d.tv/live
            var topStreams = new List<StreamModel>();


            return topStreams;
        }
    }
}
