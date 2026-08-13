using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Provider
{
    [JsiiInterface(nativeType: typeof(IStripeProviderConfig), fullyQualifiedName: "stripe.provider.StripeProviderConfig")]
    public interface IStripeProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#alias StripeProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Stripe API key. Can also be set via the STRIPE_API_KEY environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#api_key StripeProvider#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Connected account context for Connect-scoped requests. Can also be set via the STRIPE_ACCOUNT environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#stripe_account StripeProvider#stripe_account}
        /// </remarks>
        [JsiiProperty(name: "stripeAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StripeAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStripeProviderConfig), fullyQualifiedName: "stripe.provider.StripeProviderConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Provider.IStripeProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#alias StripeProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Stripe API key. Can also be set via the STRIPE_API_KEY environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#api_key StripeProvider#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Connected account context for Connect-scoped requests. Can also be set via the STRIPE_ACCOUNT environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#stripe_account StripeProvider#stripe_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stripeAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StripeAccount
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
