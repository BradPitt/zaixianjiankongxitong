using Business.BN;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace OMAC.Controllers
{
    public class MapController : ApiController
    {
        [HttpPost]
        public string GetMapEquipment()
        {
            DEVICEATTACH_BN dev_bn = new DEVICEATTACH_BN();
            StringBuilder Json = new StringBuilder();
            Json.Append("{\"0\":");
            Json.Append(dev_bn.GetMapEqipment("DEVICETYPE = 1"));
            Json.Append(",\"1\":");
            Json.Append(dev_bn.GetMapEqipment("DEVICETYPE = 2"));
            Json.Append("}");
            return Json.ToString();
        }

        [HttpPost]
        public string SearchEquipment(string type, string value)
        {           
            DEVICEATTACH_BN dev_bn = new DEVICEATTACH_BN();
            JavaScriptSerializer js = new JavaScriptSerializer();
            DEVICEATTACH model = js.Deserialize<DEVICEATTACH>(value);
            if (type == "DEVICECODE")
            {
                return dev_bn.GetMapEqipment(type + " = '" + model.DEVICECODE + "'");
            }
            else
            {
                
                return dev_bn.SearchEqipment(model);
            }
        }
    }
}
