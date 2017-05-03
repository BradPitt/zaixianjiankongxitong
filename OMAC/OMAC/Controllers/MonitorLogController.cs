using System.Web.Http;
using Newtonsoft.Json;

namespace OMAC.Controllers
{
    public class MonitorLogController : ApiController
    {

        [HttpGet]
        public string GetShuizhiList([FromUri]Entity.MonitorLog.QueryModel queryModel)
        {
            var mlbn = new Business.BN.MonitorLog();
            var rows = JsonConvert.SerializeObject(mlbn.GetShuizhiList(queryModel));
            var rst = new Entity.MonitorLog.BootstrapTableDataModel
            {
                rows = rows,
                total = 0
            };
            return JsonConvert.SerializeObject(rst);
        }

    }
}
