using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionScheduleBillingMode), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionScheduleBillingMode")]
    public interface ISubscriptionScheduleBillingMode
    {
        /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Configure behavior for flexible billing mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#flexible SubscriptionSchedule#flexible}
        /// </remarks>
        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleBillingModeFlexible\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionScheduleBillingModeFlexible? Flexible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionScheduleBillingMode), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionScheduleBillingMode")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionScheduleBillingMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configure behavior for flexible billing mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#flexible SubscriptionSchedule#flexible}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleBillingModeFlexible\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionScheduleBillingModeFlexible? Flexible
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionScheduleBillingModeFlexible?>();
            }
        }
    }
}
