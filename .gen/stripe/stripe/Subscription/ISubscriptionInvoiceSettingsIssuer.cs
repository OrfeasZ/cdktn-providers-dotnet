using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionInvoiceSettingsIssuer), fullyQualifiedName: "stripe.subscription.SubscriptionInvoiceSettingsIssuer")]
    public interface ISubscriptionInvoiceSettingsIssuer
    {
        /// <summary>Type of the account referenced.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>The connected account being referenced when `type` is `account`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#account Subscription#account}
        /// </remarks>
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Account
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionInvoiceSettingsIssuer), fullyQualifiedName: "stripe.subscription.SubscriptionInvoiceSettingsIssuer")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionInvoiceSettingsIssuer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of the account referenced.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The connected account being referenced when `type` is `account`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#account Subscription#account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Account
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
