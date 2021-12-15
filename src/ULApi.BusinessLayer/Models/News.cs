// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;

namespace ULApi.BusinessLayer.Models;

/// <summary>
/// Represents a News entity.
/// </summary>
public class News
{
    /// <summary>
    /// Title of the news.
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Link to the image of the news.
    /// </summary>
    [JsonProperty("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Date of the news.
    /// </summary>
    [JsonProperty("date")]
    public DateTime Date { get; set; }

    /// <summary>
    /// Description of the news.
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Direct link to the news.
    /// </summary>
    [JsonProperty("link")]
    public string? Link { get; set; }

    /// <summary>
    /// Type of the news.
    /// </summary>
    [JsonProperty("__typename")]
    public string? Typename { get; set; }
}

/// <summary>
/// Collection of <see cref="News"/>.
/// </summary>
public class NewsData
{
    /// <summary>
    /// Collection of <see cref="News"/>.
    /// </summary>
    [JsonProperty("news")]
    public List<News>? News { get; set; }
}

/// <summary>
/// Rooting of <see cref="NewsData"/>.
/// </summary>
public class NewsDataRoot
{
    /// <summary>
    /// Link to the <see cref="NewsData"/>.
    /// </summary>
    [JsonProperty("data")]
    public NewsData? Data { get; set; }
}