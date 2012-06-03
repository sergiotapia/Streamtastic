using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Streamtastic.Abstract;
using Streamtastic.Models;

namespace Streamtastic
{
    public class StreamFinder
    {
        private readonly IStreamRepository _iStreamRepository;

        public StreamFinder(IStreamRepository iStreamRepository)
        {
            _iStreamRepository = iStreamRepository;
        }

        public List<StreamModel> FindTopViewedStreams()
        {
            throw new NotImplementedException();
        }
    }
}
