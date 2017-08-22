// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShipyardBuyJournalEntry.cs" company="Martin Amareld">
//   Copyright(c) 2017 Martin Amareld. All rights reserved. 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace EdNetApi.Journal.JournalEntries
{
    using System;

    using EdNetApi.Common;
    using EdNetApi.Journal.Enums;

    using Newtonsoft.Json;

    public class ShipyardBuyJournalEntry : JournalEntry
    {
        public const JournalEventType EventConst = JournalEventType.ShipyardBuy;

        internal ShipyardBuyJournalEntry()
        {
        }

        [JsonIgnore]
        public override JournalEventType Event => EventConst;

        [JsonProperty("timestamp")]
        public override DateTime Timestamp { get; internal set; }

        [JsonProperty("ShipType")]
        public string ShipTypeRaw { get; internal set; }

        [JsonIgnore]
        public ShipType ShipType => ShipTypeRaw.GetEnumValue<ShipType>();

        [JsonProperty("ShipPrice")]
        public int ShipPrice { get; internal set; }

        [JsonProperty("StoreOldShip")]
        public string StoreOldShip { get; internal set; }

        [JsonProperty("StoreShipID")]
        public int StoreShipId { get; internal set; }

        [JsonProperty("SellOldShip")]
        public string SellOldShip { get; internal set; }

        [JsonProperty("SellShipID")]
        public int SellShipId { get; internal set; }

        [JsonProperty("SellPrice")]
        public int SellPrice { get; internal set; }
    }
}