using Microsoft.AspNetCore.Mvc;
using NetCoreCraw;
using NetCoreCraw.SemPortalJson.Instant;
using NetCoreCraw.SemPortalJson.Month;
using System.Dynamic;
using System.Text.Json;

namespace GoodweCrawler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodweController : ControllerBase
    {
        private readonly IGoodweService _goodweService;

        public GoodweController(IGoodweService goodweService)
        {
            _goodweService = goodweService;
        }


        /// <summary>
        /// Test site connection
        /// </summary>
        [HttpGet]
        public IActionResult Ping()
        {
            var isOnline = _goodweService.IsSiteOnline();
            if (isOnline)
            {
                return NoContent();
            } else
            {
                return Problem("Site offline");
            }
        }

    /// <summary>
    /// Read instant data by powerStationId
    /// </summary>
    /// /// <remarks>
    /// Sample request:
    ///
    ///     GET /monitor
    ///  {
    /// "date": "09/03/2022 13:39:57",
    /// "generation": 8.5,
    /// "timestamp": "2022-09-03T14:40:01.7806796+03:00"
    /// }
    /// </remarks>
    [HttpGet("monitor")]
        [Produces("application/json")]
        public async Task<IActionResult> Monitor(string? plantId)
        {
            string id = plantId ?? "7a94dbb2-2664-4f47-b9a3-8a805122de88";  //TODO for test only
            if (String.IsNullOrEmpty(id)) return BadRequest();

            Guid powerStationId = Guid.Empty;
            Guid.TryParse(id, out powerStationId);

            if (powerStationId == Guid.Empty) return BadRequest("Bad guid");

            PowerStMonitorRes? monitorRes = await _goodweService.GetInstantMonitor(powerStationId);

            if (monitorRes == null)
            {
                return NoContent();
            }

            if (monitorRes.Code == "100001")
            {
                return Unauthorized("Need login ! Send POST: /login {login:'..', pass:'..'}");
            }

            if (monitorRes.Code != "0")
            {
                return BadRequest(monitorRes.Msg);
            }

            return new JsonResult(
                new
                {
                    date = monitorRes.Data.Info.Time,
                    generation = monitorRes.Data.Kpi.Power,
                    timestamp = DateTime.Now
                });
        }

        /// <summary>
        /// Read history data array by powerStationId and between start ... end
        /// </summary>
        /// <param name="plantId">POwer station Id Guid string format</param>
        /// <param name="start">US format 08/01/2022</param>
        /// <param name="end">US format 08/01/2022 (optional)</param>
        /// <returns>historic data</returns>

        [HttpGet("history")]
        [Produces("application/json")]
        public async Task<IActionResult> GetDaysData(string? plantId, string start, string? end)
        {
            HistoryMonthRes? histRes = null;

            string id = plantId ?? "7a94dbb2-2664-4f47-b9a3-8a805122de88";  //TODO for test only
            if (String.IsNullOrEmpty(id)) return BadRequest("Bad plant Guid");

            if (String.IsNullOrEmpty(start)) return BadRequest("Missing start date ex. 08/01/2022");

            Guid powerStationId = Guid.Empty;
            Guid.TryParse(id, out powerStationId);

            if (powerStationId == Guid.Empty) return BadRequest("Bad plant Guid");

            if (String.IsNullOrEmpty(end)) {
                histRes = await _goodweService.GetMonthHistory(powerStationId, start);
            } else {
                histRes = await _goodweService.GetMonthHistory(powerStationId, start, end);
            }

            if (histRes == null)
            {
                return NoContent();
            }

            if (histRes.Code == "100001")
            {
                return Unauthorized("Need login ! Send POST: /login {login:'..', pass:'..'}");
            }
            if (histRes.Code != "0")
            {
                return BadRequest(histRes.Msg);
            }

            var res = histRes.Data.Rows.Select(d => 
                new { 
                        date = d.Date.Replace('.', '/'), 
                        generation = d.Generation 
                    });
            return new JsonResult(res);
        }

        /// <summary>
        /// Goodwe login
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /login
        ///     {
        ///        "login": xxx.ccc@sddd.com,
        ///        "pass": "Item #1"
        ///     }
        ///
        /// </remarks>
        /// <response code="202">Login OK</response>
        /// <response code="403">Bad credentials</response>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Login(object reqBody)
        {
            string? body = reqBody.ToString();

            if (String.IsNullOrEmpty(body)) return BadRequest();

            using (JsonDocument jsonDoc = JsonDocument.Parse(body))
            {
                JsonElement login = jsonDoc.RootElement.GetProperty("login");
                JsonElement pass = jsonDoc.RootElement.GetProperty("pass");

                NetCoreCraw.SemPortalJson.LoginRes? loginRes = await _goodweService.Login(login.ToString(), pass.ToString());

                if (loginRes == null) return BadRequest();

                if (loginRes.Code == 0)
                {
                    return NoContent();
                } else
                {
                    return Unauthorized();
                }
            }
        }

    
    }
}
