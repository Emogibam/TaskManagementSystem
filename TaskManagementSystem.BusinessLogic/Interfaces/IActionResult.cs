﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskManagementSystem.BusinessLogic.Interfaces
{
    public interface IActionResult
    {
        [JsonIgnore]
        HttpStatusCode Status { get; set; }

        [JsonIgnore]
        string ErrorMessage { get; set; }
    }
}
