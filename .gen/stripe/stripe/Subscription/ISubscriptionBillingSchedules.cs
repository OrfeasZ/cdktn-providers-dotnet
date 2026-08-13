using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionBillingSchedules), fullyQualifiedName: "stripe.subscription.SubscriptionBillingSchedules")]
    public interface ISubscriptionBillingSchedules
    {
        /// <summary>Specifies the end of billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bill_until Subscription#bill_until}
        /// </remarks>
        [JsiiProperty(name: "billUntil", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntil\"}")]
        stripe.Subscription.ISubscriptionBillingSchedulesBillUntil BillUntil
        {
            get;
        }

        /// <summary>Specifies which subscription items the billing schedule applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#applies_to Subscription#applies_to}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionBillingSchedulesAppliesTo" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "appliesTo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesAppliesTo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppliesTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Unique identifier for the billing schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#key Subscription#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionBillingSchedules), fullyQualifiedName: "stripe.subscription.SubscriptionBillingSchedules")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionBillingSchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the end of billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bill_until Subscription#bill_until}
            /// </remarks>
            [JsiiProperty(name: "billUntil", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntil\"}")]
            public stripe.Subscription.ISubscriptionBillingSchedulesBillUntil BillUntil
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingSchedulesBillUntil>()!;
            }

            /// <summary>Specifies which subscription items the billing schedule applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#applies_to Subscription#applies_to}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionBillingSchedulesAppliesTo" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appliesTo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesAppliesTo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppliesTo
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Unique identifier for the billing schedule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#key Subscription#key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
