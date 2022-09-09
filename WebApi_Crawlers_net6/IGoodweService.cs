using NetCoreCraw.SemPortalJson;
using NetCoreCraw.SemPortalJson.Instant;
using NetCoreCraw.SemPortalJson.Month;

namespace NetCoreCraw
{
    public interface IGoodweService
    {
        Task<PowerStMonitorRes?> GetInstantMonitor(Guid plantId);
        Task<HistoryMonthRes?> GetMonthHistory(Guid plantId, string start);
        Task<HistoryMonthRes?> GetMonthHistory(Guid plantId, string start, string end);
        bool IsSiteOnline();
        Task<LoginRes?> Login(string login, string pass);
    }
}