using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetCoreCraw.SemPortalJson.Instant
{

    public class PowerStMonitorReq
    {
        public PowerStMonitorReq()
        {
            this.Api = "v1/PowerStation/GetMonitorDetailByPowerstationId";
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
            this.PowerStationId = Guid.Parse("7a94dbb2-2664-4f47-b9a3-8a805122de88");
        }
        [JsonProperty("powerStationId")]
        public Guid PowerStationId { get; set; }
    }
}
