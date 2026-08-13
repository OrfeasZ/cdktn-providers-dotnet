using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionScheduleBillingModeFlexible), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionScheduleBillingModeFlexible")]
    public interface ISubscriptionScheduleBillingModeFlexible
    {
        /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#proration_discounts SubscriptionSchedule#proration_discounts}
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

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionScheduleBillingModeFlexible), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionScheduleBillingModeFlexible")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionScheduleBillingModeFlexible
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#proration_discounts SubscriptionSchedule#proration_discounts}
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
