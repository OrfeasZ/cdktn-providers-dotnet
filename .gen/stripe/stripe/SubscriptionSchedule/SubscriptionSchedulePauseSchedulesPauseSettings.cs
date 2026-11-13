using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings")]
    public class SubscriptionSchedulePauseSchedulesPauseSettings : stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#bill_for SubscriptionSchedule#bill_for}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "billFor", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor? BillFor
        {
            get;
            set;
        }

        /// <summary>Determines how to handle debits and credits when pausing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#invoicing_behavior SubscriptionSchedule#invoicing_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoicingBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InvoicingBehavior
        {
            get;
            set;
        }

        /// <summary>The type of pause settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
