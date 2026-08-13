using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionItem
{
    [JsiiInterface(nativeType: typeof(ISubscriptionItemDiscounts), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItemDiscounts")]
    public interface ISubscriptionItemDiscounts
    {
        /// <summary>ID of the coupon to create a new discount for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#coupon SubscriptionItem#coupon}
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

        /// <summary>ID of an existing discount on the object (or one of its ancestors) to reuse.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#discount SubscriptionItem#discount}
        /// </remarks>
        [JsiiProperty(name: "discount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Discount
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the promotion code to create a new discount for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#promotion_code SubscriptionItem#promotion_code}
        /// </remarks>
        [JsiiProperty(name: "promotionCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PromotionCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionItemDiscounts), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItemDiscounts")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionItem.ISubscriptionItemDiscounts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the coupon to create a new discount for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#coupon SubscriptionItem#coupon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Coupon
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of an existing discount on the object (or one of its ancestors) to reuse.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#discount SubscriptionItem#discount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Discount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the promotion code to create a new discount for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#promotion_code SubscriptionItem#promotion_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "promotionCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PromotionCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
