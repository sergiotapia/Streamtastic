using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Streamtastic.Models;

namespace Streamtastic.Abstract
{
    public interface IStreamRepository
    {
        List<StreamModel> FindTopViewedStreams();
        List<StreamModel> FindTopViewedStreamsByGame(string gameName);
    }
}
