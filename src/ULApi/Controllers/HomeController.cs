﻿// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace ULApi.Controllers;

[Route("api/home")]
public class HomeController
    : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hey";
    }
}
