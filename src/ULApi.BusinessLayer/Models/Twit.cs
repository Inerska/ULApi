// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace ULApi.Services.Models;

/// <summary>
/// Represents a Twit entity.
/// </summary>
public record Twit(
    int Id,
    string Author,
    string Channel,
    string Title,
    string Message,
    string Url,
    string State,
    string Cd);
