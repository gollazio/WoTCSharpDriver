﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Tanks
{
    [DataContract]
    public class TanksStatisticsData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        // todo: use enum
        [JsonProperty("mark_of_mastery")]
        public int MarkOfMastery { get; set; }

        [JsonProperty("max_frags")]
        public int MaxFrags { get; set; }

        [JsonProperty("max_xp")]
        public int MaxExpirience { get; set; }

        [JsonProperty("tank_id")]
        public string TankId { get; set; }

        [JsonProperty("in_garage")]
        public bool InGarage { get; set; }

        [JsonProperty("all")]
        public TankStatisticDetails All { get; set; }

        [JsonProperty("clan")]
        public TankStatisticDetails Clan { get; set; }

        [JsonProperty("company")]
        public TankStatisticDetails Company { get; set; }
    }

    [DataContract]
    public class TankStatisticDetails
    {
        [JsonProperty("battle_avg_xp")]
        public int BattleAverengeExpirience { get; set; }

        [JsonProperty("battles")]
        public int Battles { get; set; }

        [JsonProperty("capture_points")]
        public int CapturePoints { get; set; }

        [JsonProperty("damage_dealt")]
        public int DamageDealt { get; set; }

        [JsonProperty("damage_received")]
        public int DamageReceived { get; set; }

        [JsonProperty("draws")]
        public int Draws { get; set; }

        [JsonProperty("dropped_capture_points")]
        public int DroppedCapturePoints { get; set; }

        [JsonProperty("frags")]
        public int Frags { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("hits_percents")]
        public int HitsPercents { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("spotted")]
        public int Spotted { get; set; }

        [JsonProperty("survived_battles")]
        public int SurvivedBattles { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("xp")]
        public int Expirience { get; set; }
    }

    [DataContract]
    public class TanksStatisticsResponse : ResponseBase<IDictionary<string, TanksStatisticsData>>
    {
    }
}
