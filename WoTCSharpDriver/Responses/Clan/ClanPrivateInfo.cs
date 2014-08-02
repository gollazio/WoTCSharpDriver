﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WarApiCSharpDriver.Responses.Clan
{
    [DataContract]
    public class ClanPrivateInfo
    {
        [JsonProperty("chips_count")]
        public int ChipsCount { get; set; }

        [JsonProperty("treasury")]
        public int Treasury { get; set; }
    }
}
