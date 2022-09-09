using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using NetCoreCraw.SemPortalJson;
using NetCoreCraw.SemPortalJson.Instant;
using NetCoreCraw.SemPortalJson.Month;

using Newtonsoft.Json;

namespace NetCoreCraw
{
    public class GoodweService : IGoodweService
    {
        HttpClient client;
        public GoodweService(HttpClientHandler handler)
        {
            var baseAddress = new Uri("https://www.semsportal.com/");

            var cookieContainer = new CookieContainer();

            handler.CookieContainer = cookieContainer;
            handler.UseCookies = true;
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            client = new HttpClient(handler) { BaseAddress = baseAddress };
            client.DefaultRequestHeaders.Add("Host", "www.semsportal.com");
            client.DefaultRequestHeaders.Add("Origin", "https://www.semsportal.com");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
        }
        public bool IsSiteOnline()
        {
            var homePageResult = client.GetAsync("/").Result;

            //homePageResult.EnsureSuccessStatusCode();
            //string h = await homePageResult.Content.ReadAsStringAsync();

            return homePageResult.IsSuccessStatusCode;
        }

        public async Task<LoginRes?> Login(string login, string pass)
        {
            var loginFormData = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("account", login),
                    new KeyValuePair<string, string>("pwd", pass),
                    new KeyValuePair<string, string>("code", ""),
            });

            loginFormData.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var loginResult = client.PostAsync("/Home/Login", loginFormData).Result;

            loginResult.EnsureSuccessStatusCode();

            string loginResString = await loginResult.Content.ReadAsStringAsync();
            LoginRes? lr = JsonConvert.DeserializeObject<LoginRes>(loginResString);
            return lr;
        }
        public async Task<HistoryMonthRes?> GetMonthHistory(Guid plantId, string start)
        {
            return await this.GetMonthHistory(plantId, start, "");
        }
        public async Task<HistoryMonthRes?> GetMonthHistory(Guid plantId, string start, string end)
        {
            HistoryMonthReq p = new HistoryMonthReq();
            p.Param.Ids = plantId;
            p.Param.Start = start;
            p.Param.End = end;
            p.Param.Type = String.IsNullOrEmpty(end) ? 3 : 2;

            //var strStatParams = "{ \"api\":\"v1/Statistics/GetStatisticsData\",\"param\":{ \"ids\":\"7a94dbb2-2664-4f47-b9a3-8a805122de88\",\"range\":1,\"type\":3,\"start\":\"08/01/2022\",\"end\":\"\",\"pageIndex\":1,\"pageSize\":10} }";
            var strStatParams = JsonConvert.SerializeObject(p);
            var histDataReqFormData = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("str", strStatParams),
            });

            histDataReqFormData.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            var historyStatResult = client.PostAsync("/GopsApi/Post?s=v1/Statistics/GetStatisticsData", histDataReqFormData).Result;
            historyStatResult.EnsureSuccessStatusCode();
            string historyResponseBody = await historyStatResult.Content.ReadAsStringAsync();
            HistoryMonthRes? histRes = JsonConvert.DeserializeObject<HistoryMonthRes>(historyResponseBody);
            return histRes;
        }

        public async Task<PowerStMonitorRes?> GetInstantMonitor(Guid plantId)
        {
            PowerStMonitorReq s = new PowerStMonitorReq();
            s.Param.PowerStationId = plantId;
            //var strInstantParams = "{\"api\":\"v1/PowerStation/GetMonitorDetailByPowerstationId\",\"param\":{\"powerStationId\":\"7a94dbb2-2664-4f47-b9a3-8a805122de88\"}}";
            var strInstantParams = JsonConvert.SerializeObject(s);
            var instantDataReqFormData = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("str", strInstantParams),
            });
            instantDataReqFormData.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var instantMonitorResult = client.PostAsync("/GopsApi/Post?s=v1/PowerStation/GetMonitorDetailByPowerstationId", instantDataReqFormData).Result;

            string instantMonitorResponseBody = await instantMonitorResult.Content.ReadAsStringAsync();

            PowerStMonitorRes? instantData = JsonConvert.DeserializeObject<PowerStMonitorRes>(instantMonitorResponseBody);
            return instantData;
        }

    }
}
