#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:39:946 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 输入单个订单id等修改运单号 Response
    /// </summary>
    public class OrderSopWaybillUpdateResponse : JdResponse
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        /// <example>20032</example>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// sop出库时间
        /// </summary>
        /// <example>2011-06-22 13:25:03</example>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

    }
}
