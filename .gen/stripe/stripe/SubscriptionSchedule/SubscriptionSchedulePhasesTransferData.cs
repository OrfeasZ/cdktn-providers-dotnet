using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesTransferData")]
    public class SubscriptionSchedulePhasesTransferData : stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesTransferData
    {
        /// <summary>The account where funds from the payment will be transferred to upon payment success.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#destination SubscriptionSchedule#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the destination account. By default, the entire amount is transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#amount_percent SubscriptionSchedule#amount_percent}
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
