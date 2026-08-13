using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionBillingMode), fullyQualifiedName: "stripe.subscription.SubscriptionBillingMode")]
    public interface ISubscriptionBillingMode
    {
        /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Configure behavior for flexible billing mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#flexible Subscription#flexible}
        /// </remarks>
        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingModeFlexible\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionBillingModeFlexible? Flexible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionBillingMode), fullyQualifiedName: "stripe.subscription.SubscriptionBillingMode")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionBillingMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configure behavior for flexible billing mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#flexible Subscription#flexible}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingModeFlexible\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionBillingModeFlexible? Flexible
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingModeFlexible?>();
            }
        }
    }
}
