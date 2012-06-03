Streamtastic - eSports Streaming Library
============

Streamtastic is a .NET (C#) library that provides information for streams hosted on a wide variety of websites including Own3d and Twitch.tv API.

Just invoke Streamtastic methods, and you are returned simple to use C# POCO classes. Couldn't be easier!



How Do You Use It?
------------------
It's dead simple! Here are some basic examples, using Own3d as the source of streams. Since you work against interfaces, you only have to inject the
dependancy you want and no more changed to your code are needed.

		StreamFinder own3dStreamtastic = new StreamFinder(new Own3dStreamRepository());

		// Let's find the most viewed streamers in general.
		var topStreamers = own3dStreamtastic.FindTopViewedStreams();
		foreach (var stream in topStreamers)
		{
			Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
		}

		// You can find the top viewed streamers for any game Own3d supports.
		// For example, League of Legends.
		var topStreamersForLeagueOfLegends = own3dStreamtastic.FindTopViewedStreamsByGame("League+of+Legends");
		foreach (var stream in topStreamersForLeagueOfLegends)
		{
			Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
		}

		// Or how about Dota 2.
		var topStreamersForDota2 = own3dStreamtastic.FindTopViewedStreamsByGame("Dota+2");
		foreach (var stream in topStreamersForDota2)
		{
			Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
		}


How Does This Work?
------------------
Where a native API is implemented, we use that. However some websites do not offer an API; in those cases I just parse some HTML using
HTMLAgilityPack and ScrappySharp.


DISCLAIMER
------------------
I provide no warranties or licenses, etc. Just use it however you please. I would appreciate a mention though. :)