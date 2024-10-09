﻿using LyricsScraperNET.Providers.Abstract;

namespace LyricsScraperNET.Configuration
{
    public interface ILyricScraperClientConfig
    {
        /// <summary>
        /// Check if any external provider options is enabled
        /// </summary>
        bool IsEnabled { get; }

        IExternalProviderOptions GeniusOptions { get; }

        IExternalProviderOptions MusixmatchOptions { get; }

        IExternalProviderOptions SongLyricsOptions { get; }

        IExternalProviderOptions LyricFindOptions { get; }
    }
}
