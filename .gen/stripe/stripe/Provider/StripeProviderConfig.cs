using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Provider
{
    [JsiiByValue(fqn: "stripe.provider.StripeProviderConfig")]
    public class StripeProviderConfig : stripe.Provider.IStripeProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#alias StripeProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>Stripe API key. Can also be set via the STRIPE_API_KEY environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#api_key StripeProvider#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }

        /// <summary>Connected account context for Connect-scoped requests. Can also be set via the STRIPE_ACCOUNT environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs#stripe_account StripeProvider#stripe_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stripeAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StripeAccount
        {
            get;
            set;
        }
    }
}
