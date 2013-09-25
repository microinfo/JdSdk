#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.42928 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据指定专柜id获取转化代码 Request
    /// </summary>
    public class JingdongUnionZoneCodeGetRequest : IJdRequest<JingdongUnionZoneCodeGetResponse>
    {
        /// <summary>
        /// 专柜ID
        /// </summary>
        [XmlElement("Zone_id")]
        [JsonProperty("Zone_id")]
        public Int64 ZoneId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.zone.code.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("zone_id" ,this.ZoneId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("Zone_id", this.ZoneId);
        }

    }
}
