using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Streamtastic.Abstract;
using Streamtastic.Models;

namespace Streamtastic.Concrete
{
    public class TwitchtvStreamRepository : IStreamRepository
    {
        public List<StreamModel> FindTopViewedStreams()
        {
            throw new NotImplementedException();
        }

        public List<StreamModel> FindTopViewedStreamsByGame(string gameName)
        {
            throw new NotImplementedException();
        }
    }
}
