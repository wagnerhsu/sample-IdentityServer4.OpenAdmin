﻿//  
//  StatisticsController.cs
//  Copyright (c) Johan Boström. All rights reserved.
//  Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
//  

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer4.OpenAdmin.API.Controllers
{
    [Route(OpenAdminApiOptions.DefaultApiPrefix + "statistics")]
    public class StatisticsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetStatisticsAsync() => Ok(new
        {
        });
    }
}