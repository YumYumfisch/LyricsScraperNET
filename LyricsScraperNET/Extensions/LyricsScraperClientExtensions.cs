using LyricsScraperNET.Providers.AZLyrics;
using LyricsScraperNET.Providers.Genius;
using LyricsScraperNET.Providers.LyricFind;
using LyricsScraperNET.Providers.Models;
using LyricsScraperNET.Providers.SongLyrics;

namespace LyricsScraperNET.Extensions
{
    public static class LyricsScraperClientExtensions
    {
        public static ILyricsScraperClient WithAZLyrics(this ILyricsScraperClient lyricsScraperClient)
        {
            lyricsScraperClient.AddProvider(new AZLyricsProvider());
            return lyricsScraperClient;
        }

        public static ILyricsScraperClient WithGenius(this ILyricsScraperClient lyricsScraperClient)
        {
            lyricsScraperClient.AddProvider(new GeniusProvider());
            return lyricsScraperClient;
        }

        public static ILyricsScraperClient WithSongLyrics(this ILyricsScraperClient lyricsScraperClient)
        {
            lyricsScraperClient.AddProvider(new SongLyricsProvider());
            return lyricsScraperClient;
        }

        public static ILyricsScraperClient WithLyricFind(this ILyricsScraperClient lyricsScraperClient)
        {
            lyricsScraperClient.AddProvider(new LyricFindProvider());
            return lyricsScraperClient;
        }

        /// <summary>
        /// Configure LyricsScraperClient with all available providers in <seealso cref="ExternalProviderType"/>.
        /// Search lyrics enabled by default for all providers.
        /// </summary>
        public static ILyricsScraperClient WithAllProviders(this ILyricsScraperClient lyricsScraperClient)
        {
            return lyricsScraperClient
                .WithGenius()
                .WithAZLyrics()
                .WithSongLyrics()
                .WithLyricFind();
        }
    }
}
