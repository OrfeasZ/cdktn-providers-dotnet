using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions
    {
        /// <summary>Transaction type of the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#transaction_type Subscription#transaction_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransactionType
        {
            get;
            set;
        }
    }
}
