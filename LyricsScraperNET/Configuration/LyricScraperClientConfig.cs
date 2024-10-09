﻿using LyricsScraperNET.Providers.Abstract;
using LyricsScraperNET.Providers.Genius;
using LyricsScraperNET.Providers.LyricFind;
using LyricsScraperNET.Providers.Musixmatch;
using LyricsScraperNET.Providers.SongLyrics;

namespace LyricsScraperNET.Configuration
{
    public sealed class LyricScraperClientConfig : ILyricScraperClientConfig
    {
        public const string ConfigurationSectionName = "LyricScraperClient";

        public IExternalProviderOptions GeniusOptions { get; set; } = new GeniusOptions();

        public IExternalProviderOptions MusixmatchOptions { get; set; } = new MusixmatchOptions();

        public IExternalProviderOptions SongLyricsOptions { get; set; } = new SongLyricsOptions();

        public IExternalProviderOptions LyricFindOptions { get; set; } = new LyricFindOptions();

        public bool IsEnabled
        {
            get
            {
                return GeniusOptions.Enabled
            || MusixmatchOptions.Enabled
            || SongLyricsOptions.Enabled
            || LyricFindOptions.Enabled;
            }
        }
    }
}
