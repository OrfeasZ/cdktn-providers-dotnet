using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.quote.QuoteTransferData")]
    public class QuoteTransferData : stripe.Quote.IQuoteTransferData
    {
        /// <summary>The account where funds from the payment will be transferred to upon payment success.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#destination Quote#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>The amount in cents (or local equivalent) that will be transferred to the destination account when the invoice is paid.</summary>
        /// <remarks>
        /// By default, the entire amount is transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#amount Quote#amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the destination account. By default, the entire amount will be transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#amount_percent Quote#amount_percent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AmountPercent
        {
            get;
            set;
        }
    }
}
