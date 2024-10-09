using LyricsScraperNET.Providers.Abstract;
using LyricsScraperNET.Providers.AZLyrics;
using LyricsScraperNET.Providers.Genius;
using LyricsScraperNET.Providers.LyricFind;
using LyricsScraperNET.Providers.SongLyrics;

namespace LyricsScraperNET.Configuration
{
    public sealed class LyricScraperClientConfig : ILyricScraperClientConfig
    {
        public const string ConfigurationSectionName = "LyricScraperClient";

        public IExternalProviderOptions AZLyricsOptions { get; set; } = new AZLyricsOptions();

        public IExternalProviderOptions GeniusOptions { get; set; } = new GeniusOptions();

        public IExternalProviderOptions SongLyricsOptions { get; set; } = new SongLyricsOptions();

        public IExternalProviderOptions LyricFindOptions { get; set; } = new LyricFindOptions();

        public bool IsEnabled => AZLyricsOptions.Enabled
            || GeniusOptions.Enabled
            || SongLyricsOptions.Enabled
            || LyricFindOptions.Enabled;
    }
}
