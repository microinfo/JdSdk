#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:55.04871 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据促销编号获取促销的活动规则 Request
    /// </summary>
    public class JingdongSellerPromotionActivitymodeGetRequest : JdRequestBase<JingdongSellerPromotionActivitymodeGetResponse>
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>123456</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.activitymode.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("promo_id", this.PromoId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
        }

    }
}
