using ArchiSteamFarm.Plugins;
using SteamKit2;
using System;
using System.Diagnostics.CodeAnalysis;

namespace ArchiSteamFarm.CustomPlugins.SendSpareCards
{
	public class Plugin : IPlugin, IBotConnection
	{
		public string Name => nameof(SendSpareCards);

		public Version Version => new Version("1.0.0");

		public void OnLoaded()
		{
			ASF.ArchiLogger.LogGenericInfo($"{Name}已加载");
		}

		public void OnBotDisconnected([NotNull] Bot bot, EResult reason)
		{

		}

		public async void OnBotLoggedOn([NotNull] Bot bot)
		{
			const string request = "/market?l=english&xml=1";
			var doc = await bot.ArchiWebHandler.UrlGetToHtmlDocumentWithSession(ArchiWebHandler.SteamCommunityURL, request);
			ASF.ArchiLogger.LogGenericInfo("this is a test");
		}
	}
}
