using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.promotionCode.PromotionCodePromotion")]
    public class PromotionCodePromotion : stripe.PromotionCode.IPromotionCodePromotion
    {
        /// <summary>The type of promotion.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/promotion_code#type PromotionCode#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>If promotion `type` is `coupon`, the coupon for this promotion.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/promotion_code#coupon PromotionCode#coupon}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Coupon
        {
            get;
            set;
        }
    }
}
