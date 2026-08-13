using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionBillingModeFlexible), fullyQualifiedName: "stripe.subscription.SubscriptionBillingModeFlexible")]
    public interface ISubscriptionBillingModeFlexible
    {
        /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#proration_discounts Subscription#proration_discounts}
        /// </remarks>
        [JsiiProperty(name: "prorationDiscounts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProrationDiscounts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionBillingModeFlexible), fullyQualifiedName: "stripe.subscription.SubscriptionBillingModeFlexible")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionBillingModeFlexible
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#proration_discounts Subscription#proration_discounts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationDiscounts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationDiscounts
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
