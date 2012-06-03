Streamtastic - eSports Streaming Library
============

Streamtastic is a .NET (C#) library that provides information for streams hosted on a wide variety of websites including Own3d and Twitch.tv API.

Just invoke Streamtastic methods, and you are returned simple to use C# POCO classes. Couldn't be easier!



How Do You Use It?
------------------
It's dead simple! Since you work against interfaces, you only have to inject the dependancy you want and no more changes to your code are needed.	


Own3d Examples:
------------------

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


Twitch.TV Examples:
------------------

    StreamFinder twitchTv = new StreamFinder(new TwitchtvStreamRepository());

	// Let's find the most viewed streamers in general.
	var topStreamers = twitchTv.FindTopViewedStreams();
	foreach (var stream in topStreamers)
	{
		Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
	}

	// You can find the top viewed streamers for any game Own3d supports.
	// For example, League of Legends.
	var topStreamersForLeagueOfLegends = twitchTv.FindTopViewedStreamsByGame("League of Legends");
	foreach (var stream in topStreamersForLeagueOfLegends)
	{
		Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
	}

	// Or how about Dota 2.
	var topStreamersForDota2 = twitchTv.FindTopViewedStreamsByGame("Dota 2");
	foreach (var stream in topStreamersForDota2)
	{
		Console.WriteLine(String.Format("{0} - Viewers: {1}", stream.Title, stream.ViewerCount));
	}


How Does This Work?
------------------
Where a native API is implemented, we use that. However some websites do not offer an API; in those cases I just parse some HTML using
HTMLAgilityPack and ScrappySharp.


Released under the MIT License
------------------
Copyright (c) 2012 Sergio Tapia Gutierrez

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial 
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN 
NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
