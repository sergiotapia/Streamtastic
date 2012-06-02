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
        public List<StreamModel> FindMostViewedStreams()
        {
            throw new NotImplementedException();
        }
    }
}
