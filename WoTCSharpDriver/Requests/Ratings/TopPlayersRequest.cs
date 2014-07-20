﻿using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.Ratings
{
    public class TopPlayersRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "top";
            }
        }

        // todo: create constants for it
        [RequestParameter("type", true)]
        public string Type { get; set; }

        [RequestParameter("rank_field", true)]
        public string RankField { get; set; }

        // todo: use DateTime
        [RequestParameter("date", false)]
        public string Date { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }
    }
}
