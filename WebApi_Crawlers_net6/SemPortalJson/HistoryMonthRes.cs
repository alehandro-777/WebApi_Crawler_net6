using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetCoreCraw.SemPortalJson.Month
{
        public class HistoryMonthRes
        {
            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("function")]
            public string Function { get; set; }

            [JsonProperty("hasError")]
            public bool HasError { get; set; }

            [JsonProperty("msg")]
            public string Msg { get; set; }

            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public class Components
        {
            [JsonProperty("para")]
            public string Para { get; set; }

            [JsonProperty("langVer")]
            public long LangVer { get; set; }

            [JsonProperty("timeSpan")]
            public long TimeSpan { get; set; }

            [JsonProperty("api")]
            public Uri Api { get; set; }

            [JsonProperty("msgSocketAdr")]
            public object MsgSocketAdr { get; set; }
        }

        public class Data
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("rows")]
            public Row[] Rows { get; set; }
        }

        public class Row
        {
            [JsonProperty("plant")]
            public string Plant { get; set; }

            [JsonProperty("classification")]
            public string Classification { get; set; }

            [JsonProperty("contributionRatio")]
            public long ContributionRatio { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("date_string")]
            public object DateString { get; set; }

            [JsonProperty("feedinPrice")]
            public double FeedinPrice { get; set; }

            [JsonProperty("electricalTariff")]
            public long ElectricalTariff { get; set; }

            [JsonProperty("capacity")]
            public double Capacity { get; set; }

            [JsonProperty("generation")]
            public double Generation { get; set; }

            [JsonProperty("yield")]
            public double Yield { get; set; }

            [JsonProperty("sell")]
            public long Sell { get; set; }

            [JsonProperty("buy")]
            public long Buy { get; set; }

            [JsonProperty("etotalLoad")]
            public double EtotalLoad { get; set; }

            [JsonProperty("selfUseRatio")]
            public long SelfUseRatio { get; set; }

            [JsonProperty("selfUseOfPv")]
            public double SelfUseOfPv { get; set; }

            [JsonProperty("load")]
            public double Load { get; set; }

            [JsonProperty("hasLt4")]
            public bool HasLt4 { get; set; }

            [JsonProperty("mockData")]
            public long MockData { get; set; }

            [JsonProperty("radiationDose")]
            public long RadiationDose { get; set; }
        }

    }
