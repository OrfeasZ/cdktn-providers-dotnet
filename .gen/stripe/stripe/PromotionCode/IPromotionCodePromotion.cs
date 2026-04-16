using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    [JsiiInterface(nativeType: typeof(IPromotionCodePromotion), fullyQualifiedName: "stripe.promotionCode.PromotionCodePromotion")]
    public interface IPromotionCodePromotion
    {
        /// <summary>Specifies the type of promotion.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#type PromotionCode#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>If promotion `type` is `coupon`, the coupon for this promotion code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#coupon PromotionCode#coupon}
        /// </remarks>
        [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Coupon
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPromotionCodePromotion), fullyQualifiedName: "stripe.promotionCode.PromotionCodePromotion")]
        internal sealed class _Proxy : DeputyBase, stripe.PromotionCode.IPromotionCodePromotion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the type of promotion.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#type PromotionCode#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If promotion `type` is `coupon`, the coupon for this promotion code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#coupon PromotionCode#coupon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Coupon
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
