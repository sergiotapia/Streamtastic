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
        public List<StreamModel> FindMostViewedStreams()
        {
            throw new NotImplementedException();
        }
    }
}
