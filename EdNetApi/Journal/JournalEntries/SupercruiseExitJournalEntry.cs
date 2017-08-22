// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SupercruiseExitJournalEntry.cs" company="Martin Amareld">
//   Copyright(c) 2017 Martin Amareld. All rights reserved. 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace EdNetApi.Journal.JournalEntries
{
    using System;

    using Newtonsoft.Json;

    public class SupercruiseExitJournalEntry : JournalEntry
    {
        public const JournalEventType EventConst = JournalEventType.SupercruiseExit;

        internal SupercruiseExitJournalEntry()
        {
        }

        [JsonIgnore]
        public override JournalEventType Event => EventConst;

        [JsonProperty("timestamp")]
        public override DateTime Timestamp { get; internal set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; internal set; }

        [JsonProperty("Body")]
        public string Body { get; internal set; }

        [JsonProperty("BodyType")]
        public string BodyType { get; internal set; }
    }
}