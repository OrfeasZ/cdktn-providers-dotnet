using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    [JsiiInterface(nativeType: typeof(IPromotionCodeRestrictionsCurrencyOptions), fullyQualifiedName: "stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions")]
    public interface IPromotionCodeRestrictionsCurrencyOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#key PromotionCode#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase must be $100 or more to work).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount PromotionCode#minimum_amount}
        /// </remarks>
        [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumAmount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPromotionCodeRestrictionsCurrencyOptions), fullyQualifiedName: "stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#key PromotionCode#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase must be $100 or more to work).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount PromotionCode#minimum_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumAmount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
