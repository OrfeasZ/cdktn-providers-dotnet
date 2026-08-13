using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPendingInvoiceItemInterval")]
    public class SubscriptionPendingInvoiceItemInterval : stripe.Subscription.ISubscriptionPendingInvoiceItemInterval
    {
        /// <summary>Specifies invoicing frequency. Either `day`, `week`, `month` or `year`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#interval Subscription#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>The number of intervals between invoices.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of one year interval allowed (1 year, 12 months, or 52 weeks).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#interval_count Subscription#interval_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalCount
        {
            get;
            set;
        }
    }
}
