using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionBillingSchedulesBillUntil), fullyQualifiedName: "stripe.subscription.SubscriptionBillingSchedulesBillUntil")]
    public interface ISubscriptionBillingSchedulesBillUntil
    {
        /// <summary>Describes how the billing schedule will determine the end date. Either `duration` or `timestamp`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Specifies the billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#duration Subscription#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntilDuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>If specified, the billing schedule will apply until the specified timestamp.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#timestamp Subscription#timestamp}
        /// </remarks>
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionBillingSchedulesBillUntil), fullyQualifiedName: "stripe.subscription.SubscriptionBillingSchedulesBillUntil")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionBillingSchedulesBillUntil
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes how the billing schedule will determine the end date. Either `duration` or `timestamp`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#duration Subscription#duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntilDuration\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration? Duration
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration?>();
            }

            /// <summary>If specified, the billing schedule will apply until the specified timestamp.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#timestamp Subscription#timestamp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timestamp
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
