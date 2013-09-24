#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:55.04871 +08:00
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
    /// 根据促销编号获取促销的活动规则 Response
    /// </summary>
    public class JingdongSellerPromotionActivitymodeGetResponse : JdResponse
    {
        /// <summary>
        /// 促销活动规则
        /// </summary>
        [XmlElement("activity_mode")]
        [JsonProperty("activity_mode")]
        public ActivityModeVO ActivityMode
        {
            get;
            set;
        }

    }
}