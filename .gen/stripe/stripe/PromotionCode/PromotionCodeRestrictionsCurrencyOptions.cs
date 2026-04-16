using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions")]
    public class PromotionCodeRestrictionsCurrencyOptions : stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#key PromotionCode#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase must be $100 or more to work).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount PromotionCode#minimum_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumAmount
        {
            get;
            set;
        }
    }
}
