#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:45:618 +08:00
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
    /// 获取商家已经开通的类目。 Response
    /// </summary>
    public class WarecatsGetResponse : JdResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlElement("item_cats")]
        [JsonProperty("item_cats")]
        public List<Category> ItemCats
        {
            get;
            set;
        }

    }
}