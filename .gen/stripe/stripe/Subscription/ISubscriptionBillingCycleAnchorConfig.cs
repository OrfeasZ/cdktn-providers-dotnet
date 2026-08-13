using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionBillingCycleAnchorConfig), fullyQualifiedName: "stripe.subscription.SubscriptionBillingCycleAnchorConfig")]
    public interface ISubscriptionBillingCycleAnchorConfig
    {
        /// <summary>The day of the month of the billing_cycle_anchor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#day_of_month Subscription#day_of_month}
        /// </remarks>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}")]
        double DayOfMonth
        {
            get;
        }

        /// <summary>The hour of the day of the billing_cycle_anchor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#hour Subscription#hour}
        /// </remarks>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hour
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minute of the hour of the billing_cycle_anchor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#minute Subscription#minute}
        /// </remarks>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minute
        {
            get
            {
                return null;
            }
        }

        /// <summary>The month to start full cycle billing periods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#month Subscription#month}
        /// </remarks>
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Month
        {
            get
            {
                return null;
            }
        }

        /// <summary>The second of the minute of the billing_cycle_anchor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#second Subscription#second}
        /// </remarks>
        [JsiiProperty(name: "second", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Second
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionBillingCycleAnchorConfig), fullyQualifiedName: "stripe.subscription.SubscriptionBillingCycleAnchorConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionBillingCycleAnchorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The day of the month of the billing_cycle_anchor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#day_of_month Subscription#day_of_month}
            /// </remarks>
            [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}")]
            public double DayOfMonth
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The hour of the day of the billing_cycle_anchor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#hour Subscription#hour}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minute of the hour of the billing_cycle_anchor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#minute Subscription#minute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minute
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The month to start full cycle billing periods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#month Subscription#month}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Month
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The second of the minute of the billing_cycle_anchor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#second Subscription#second}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "second", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Second
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
