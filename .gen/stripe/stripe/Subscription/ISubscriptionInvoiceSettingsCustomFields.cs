using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionInvoiceSettingsCustomFields), fullyQualifiedName: "stripe.subscription.SubscriptionInvoiceSettingsCustomFields")]
    public interface ISubscriptionInvoiceSettingsCustomFields
    {
        /// <summary>The name of the custom field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#name Subscription#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The value of the custom field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#value Subscription#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionInvoiceSettingsCustomFields), fullyQualifiedName: "stripe.subscription.SubscriptionInvoiceSettingsCustomFields")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionInvoiceSettingsCustomFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the custom field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#name Subscription#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value of the custom field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#value Subscription#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
