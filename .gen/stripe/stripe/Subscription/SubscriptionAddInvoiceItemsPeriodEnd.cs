using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionAddInvoiceItemsPeriodEnd")]
    public class SubscriptionAddInvoiceItemsPeriodEnd : stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd
    {
        /// <summary>Select how to calculate the end of the invoice item period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#type Subscription#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>A precise Unix timestamp for the end of the invoice item period.</summary>
        /// <remarks>
        /// Must be greater than or equal to <c>period.start</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#timestamp Subscription#timestamp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timestamp
        {
            get;
            set;
        }
    }
}
