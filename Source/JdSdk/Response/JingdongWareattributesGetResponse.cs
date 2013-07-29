#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.54274 +08:00
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
    /// 获取类目下的属性属性值信息。 Response
    /// </summary>
    public class JingdongWareattributesGetResponse : JdResponse
    {
        /// <summary>
        /// 类目属性信息
        /// </summary>
        [XmlElement("wareAttributes")]
        [JsonProperty("wareAttributes")]
        public List< WareAttribute > WareAttributes
        {
            get;
            set;
        }

    }
}