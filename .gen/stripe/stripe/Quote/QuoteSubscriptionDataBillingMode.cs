using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.quote.QuoteSubscriptionDataBillingMode")]
    public class QuoteSubscriptionDataBillingMode : stripe.Quote.IQuoteSubscriptionDataBillingMode
    {
        /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#type Quote#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#flexible Quote#flexible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingModeFlexible\"}", isOptional: true)]
        public stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible? Flexible
        {
            get;
            set;
        }
    }
}
