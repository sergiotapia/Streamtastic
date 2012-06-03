using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Streamtastic.Concrete;

namespace Streamtastic.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamFinder own3dStreamtastic = new StreamFinder(new Own3dStreamRepository());

            //Find a collection of the most viewed streamers.
            var topStreamers = own3dStreamtastic.FindTopViewedStreams();

            foreach (var stream in topStreamers)
            {
                Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
            }

            Console.ReadKey(true);
        }
    }
}
