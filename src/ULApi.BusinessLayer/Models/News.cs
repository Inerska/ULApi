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
    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("image")]
    public string? Image { get; set; }

    [JsonProperty("date")]
    public DateTime Date { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("link")]
    public string? Link { get; set; }

    [JsonProperty("__typename")]
    public string? Typename { get; set; }
}

public class NewsData
{
    [JsonProperty("news")]
    public List<News>? News { get; set; }
}

public class NewsDataRoot
{
    [JsonProperty("data")]
    public NewsData? Data { get; set; }
}