using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionAddInvoiceItemsPeriod")]
    public class SubscriptionAddInvoiceItemsPeriod : stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod
    {
        /// <summary>End of the invoice item period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end Subscription#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodEnd\"}")]
        public stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd End
        {
            get;
            set;
        }

        /// <summary>Start of the invoice item period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#start Subscription#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodStart\"}")]
        public stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart Start
        {
            get;
            set;
        }
    }
}
