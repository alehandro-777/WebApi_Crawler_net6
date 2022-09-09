using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetCoreCraw.SemPortalJson.Month
{
    public class HistoryMonthReq 
    {
        public HistoryMonthReq()
        {
            this.Api = "v1/Statistics/GetStatisticsData";
            this.Param = new Param();
        }
        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("param")]
        public Param Param { get; set; }
    }

    public class Param
    {
        public Param()
        {
            this.Ids = Guid.Parse("7a94dbb2-2664-4f47-b9a3-8a805122de88");
            this.Range = 1;
            //2 - range start...end (2), 3 - month(31), 4 - month(12) 5- prev month(31) 6- month prev year(12) 7 -years
            this.Type = 2;  
            this.PageIndex = 1;
            this.PageSize = 31;
            this.Start = "08/01/2022";
            this.End = "08/01/2022";
        }
        [JsonProperty("ids")]
        public Guid Ids { get; set; }

        [JsonProperty("range")]
        public long Range { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("pageIndex")]
        public long PageIndex { get; set; }

        [JsonProperty("pageSize")]
        public long PageSize { get; set; }
    }
}
