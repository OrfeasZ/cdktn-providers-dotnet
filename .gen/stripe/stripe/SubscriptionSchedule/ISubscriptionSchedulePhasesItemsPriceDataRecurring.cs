using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePhasesItemsPriceDataRecurring), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesItemsPriceDataRecurring")]
    public interface ISubscriptionSchedulePhasesItemsPriceDataRecurring
    {
        /// <summary>Specifies billing frequency. Either `day`, `week`, `month` or `year`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#interval SubscriptionSchedule#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>The number of intervals between subscription billings.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of three years interval allowed (3 years, 36 months, or 156 weeks).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#interval_count SubscriptionSchedule#interval_count}
        /// </remarks>
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePhasesItemsPriceDataRecurring), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesItemsPriceDataRecurring")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesItemsPriceDataRecurring
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies billing frequency. Either `day`, `week`, `month` or `year`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#interval SubscriptionSchedule#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of intervals between subscription billings.</summary>
            /// <remarks>
            /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of three years interval allowed (3 years, 36 months, or 156 weeks).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#interval_count SubscriptionSchedule#interval_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
