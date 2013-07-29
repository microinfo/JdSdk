#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.00414 +08:00
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
    /// 查询站长的结算单信息 Response
    /// </summary>
    public class JingdongUnionMasterBillSearchResponse : JdResponse
    {
        /// <summary>
        /// 结算数据
        /// </summary>
        [XmlElement("bill_list")]
        [JsonProperty("bill_list")]
        public List<MasterBillVo> BillList
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("page_total")]
        [JsonProperty("page_total")]
        public Nullable<Decimal> PageTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Nullable<Decimal> PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Decimal> PageSize
        {
            get;
            set;
        }

    }
}