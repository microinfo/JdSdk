#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 23:04:28.14932 +08:00
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
    /// 查询商家基本信息，包括商家编号、商家类型、店铺编号、店铺名称、主营类目编号。 Response
    /// </summary>
    public class JingdongSellerVenderInfoGetResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("vender_info_result")]
        [JsonProperty("vender_info_result")]
        public List<VenderInfo> VenderInfoResult
        {
            get;
            set;
        }
    }
}
