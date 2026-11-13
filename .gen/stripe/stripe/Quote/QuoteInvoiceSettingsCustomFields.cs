using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.quote.QuoteInvoiceSettingsCustomFields")]
    public class QuoteInvoiceSettingsCustomFields : stripe.Quote.IQuoteInvoiceSettingsCustomFields
    {
        /// <summary>The name of the custom field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/quote#name Quote#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The value of the custom field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/quote#value Quote#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
