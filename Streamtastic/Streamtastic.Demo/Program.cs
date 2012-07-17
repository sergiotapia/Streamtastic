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
            //// Examples for Own3d:

            //// Create a StreamFinder object.
            //StreamFinder own3dStreamtastic = new StreamFinder(new Own3dStreamRepository());

            //// Let's find the most viewed streamers in general.
            //var topStreamers = own3dStreamtastic.FindTopViewedStreams();
            //foreach (var stream in topStreamers)
            //{
            //    Console.WriteLine(String.Format("{0} - Viewers: {1} - URL: {2}", stream.Title, stream.ViewerCount, stream.ChannelUrl));
            //}

            //// You can find the top viewed streamers for any game Own3d supports.
            //// For example, League of Legends.
            //var topStreamersForLeagueOfLegends = own3dStreamtastic.FindTopViewedStreamsByGame("League+of+Legends");
            //foreach (var stream in topStreamersForLeagueOfLegends)
            //{
            //    Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
            //}

            //// Or how about Dota 2.
            //var topStreamersForDota2 = own3dStreamtastic.FindTopViewedStreamsByGame("Dota+2");
            //foreach (var stream in topStreamersForDota2)
            //{
            //    Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
            //}
            

            /*************************************************************/

            // Examples for Twitch.TV:

            // Create a StreamFinder object.
            StreamFinder twitchTvStreamtastic = new StreamFinder(new TwitchtvStreamRepository());
            
            //var topStreamersTwitch = twitchTvStreamtastic.FindTopViewedStreams();
            //foreach (var stream in topStreamersTwitch)
            //{
            //    Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
            //}
            
            var topStreamersTwitchForDota2 = twitchTvStreamtastic.FindTopViewedStreamsByGame("Dota 2");
            foreach (var stream in topStreamersTwitchForDota2)
            {
                Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
            }

            Console.ReadKey(true);
        }
    }
}
