using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Provider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.provider.StripeProviderConfig")]
    public class StripeProviderConfig : stripe.Provider.IStripeProviderConfig
    {
        /// <summary>Stripe API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs#api_key StripeProvider#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs#alias StripeProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }
    }
}
