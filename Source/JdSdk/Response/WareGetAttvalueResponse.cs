#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:46:022 +08:00
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
    /// 获取类目下的属性值信息。 Response
    /// </summary>
    public class WareGetAttvalueResponse : JdResponse
    {
        /// <summary>
        /// 类目属性值信息
        /// </summary>
        [XmlElement("att_values")]
        [JsonProperty("att_values")]
        public List<AttValue> AttValues
        {
            get;
            set;
        }

    }
}
