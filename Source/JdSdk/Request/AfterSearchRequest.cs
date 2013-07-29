#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:237 +08:00
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
    /// 根据条件检索订单信息 Request
    /// </summary>
    public class AfterSearchRequest : IJdRequest<AfterSearchResponse>
    {
        /// <summary>
        /// 查询字段对应Field中的key，查询字段的值对应Field中的value 查询字段键值对，详见“查询字段”
        /// </summary>
        /// <example>字段:值;字段:值queryField.setKey(return_id) ;queryField.setValue(11231)</example>
        [XmlElement("query_fields")]
        [JsonProperty("query_fields")]
        public List < Field> QueryFields
        {
            get;
            set;
        }

        /// <summary>
        /// 返回字段选择,每个字段以逗号分隔
        /// </summary>
        [XmlElement("select_fields")]
        [JsonProperty("select_fields")]
        public String SelectFields
        {
            get;
            set;
        }

        /// <summary>
        /// 分页号：1-100
        /// </summary>
        /// <example>100</example>
        [XmlElement("page")]
        [JsonProperty("page")]
        public String Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页的条数（最大page_size 10条）
        /// </summary>
        /// <example>10</example>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public String PageSize
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.after.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("query_fields" ,this.QueryFields);
            paramters.Add("select_fields" ,this.SelectFields);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("select_fields", this.SelectFields);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
