﻿using SoundCloud.NET.Attributes;
using System;

namespace SoundCloud.NET
{
    /// <summary>
    /// Provides a collection of search parameters
    /// </summary>
    public class SearchParameters
    {
        #region Public Constructors

        /// <summary>
        /// Creates an empty collection of search parameters
        /// </summary>
        public SearchParameters()
        {

        }

        /// <summary>
        /// Creates a collection of search parameters including a general search string
        /// </summary>
        /// <param name="searchString"></param>
        public SearchParameters(string searchString)
        {
            SearchString = searchString;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Beats per Minute
        /// </summary>
        [UrlParameterProperty("bpm")]
        public float? Bpm { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        [UrlParameterProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [UrlParameterProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Search for downloadable tracks only
        /// </summary>
        [UrlParameterProperty("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [UrlParameterProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Embeddable by
        /// </summary>
        [UrlParameterProperty("embeddable_by")]
        public string EmbeddableBy { get; set; }

        /// <summary>
        /// Genre
        /// </summary>
        [UrlParameterProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// License
        /// </summary>
        [UrlParameterProperty("license")]
        public string License { get; set; }

        /// <summary>
        /// General search string
        /// </summary>
        [UrlParameterProperty("q")]
        public string SearchString { get; set; }

        /// <summary>
        /// Sharing
        /// </summary>
        [UrlParameterProperty("sharing")]
        public string Sharing { get; set; }

        /// <summary>
        /// Search fpr streamable tracks only
        /// </summary>
        [UrlParameterProperty("streamable")]
        public bool? Streamable { get; set; }

        /// <summary>
        /// Track title
        /// </summary>
        [UrlParameterProperty("title")]
        public string Title { get; set; }

        #endregion Public Properties
    }
}
