﻿using LyricsScraperNET.Models.Requests;
using LyricsScraperNET.Models.Responses;
using LyricsScraperNET.Providers.AZLyrics;
using LyricsScraperNET.Providers.Models;
using LyricsScraperNET.TestShared.Extensions;
using LyricsScraperNET.TestShared.Providers;
using LyricsScraperNET.UnitTest.TestModel;
using Xunit;

namespace LyricsScraperNET.UnitTest.Providers.AZLyrics
{
    public class AZLyricsProviderTest : ProviderTestBase
    {
        [Theory]
        [MemberData(nameof(GetTestData), parameters: "Providers\\AZLyrics\\test_data.json")]
        public void SearchLyric_UnitDynamicData_AreEqual(LyricsTestData testData)
        {
            // Arrange
            var lyricsClient = new AZLyricsProvider();
            lyricsClient.ConfigureExternalProvider(testData);

            SearchRequest searchRequest = CreateSearchRequest(testData);

            // Act
            var searchResult = lyricsClient.SearchLyric(searchRequest);

            // Assert
            Assert.NotNull(searchResult);
            Assert.Equal(ResponseStatusCode.Success, searchResult.ResponseStatusCode);
            Assert.True(string.IsNullOrEmpty(searchResult.ResponseMessage));
            Assert.Equal(ExternalProviderType.AZLyrics, searchResult.ExternalProviderType);
            Assert.Equal(testData.LyricResultData.Replace("\r\n", "\n"), searchResult.LyricText.Replace("\r\n", "\n"));
        }
    }
}
