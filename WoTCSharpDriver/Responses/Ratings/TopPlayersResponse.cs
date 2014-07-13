﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Ratings
{
    // todo maybe we should use one class for
    // NeighborsResponse, PlayerRatingsResponse and TopPlayersResponse
    [DataContract]
    public class TopPlayersResponse : ResponseBase<IList<PlayerRatingsData>>
    {
    }
}