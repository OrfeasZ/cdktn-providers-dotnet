using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriod")]
    public class SubscriptionSchedulePhasesAddInvoiceItemsPeriod : stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#end SubscriptionSchedule#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd\"}")]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#start SubscriptionSchedule#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodStart\"}")]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodStart Start
        {
            get;
            set;
        }
    }
}
