using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePhasesItemsBillingThresholds), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesItemsBillingThresholds")]
    public interface ISubscriptionSchedulePhasesItemsBillingThresholds
    {
        /// <summary>Usage threshold that triggers the subscription to create an invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#usage_gte SubscriptionSchedule#usage_gte}
        /// </remarks>
        [JsiiProperty(name: "usageGte", typeJson: "{\"primitive\":\"number\"}")]
        double UsageGte
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePhasesItemsBillingThresholds), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesItemsBillingThresholds")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesItemsBillingThresholds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Usage threshold that triggers the subscription to create an invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#usage_gte SubscriptionSchedule#usage_gte}
            /// </remarks>
            [JsiiProperty(name: "usageGte", typeJson: "{\"primitive\":\"number\"}")]
            public double UsageGte
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
