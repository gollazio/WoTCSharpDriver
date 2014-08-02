﻿using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.GlobalWar
{
    public class TournamentsRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tournaments";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        [RequestParameter("province_id", true)]
        public string ProvinceId { get; set; }
    }
}