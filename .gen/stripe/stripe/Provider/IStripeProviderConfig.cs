using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Provider
{
    [JsiiInterface(nativeType: typeof(IStripeProviderConfig), fullyQualifiedName: "stripe.provider.StripeProviderConfig")]
    public interface IStripeProviderConfig
    {
        /// <summary>Stripe API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs#api_key StripeProvider#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiKey
        {
            get;
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs#alias StripeProvider#alias}
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

        [JsiiTypeProxy(nativeType: typeof(IStripeProviderConfig), fullyQualifiedName: "stripe.provider.StripeProviderConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Provider.IStripeProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Stripe API key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs#api_key StripeProvider#api_key}
            /// </remarks>
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs#alias StripeProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
