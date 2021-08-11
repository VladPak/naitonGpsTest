using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaitonGps.Models
{
    public class Roles
    {
        [JsonProperty]
        public int Id { get; set; }

        [JsonProperty]
        public string RoleRight { get; set; }

    }
}
