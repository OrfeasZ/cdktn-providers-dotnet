using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#financial_connections Subscription#financial_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections? FinancialConnections
        {
            get;
            set;
        }

        /// <summary>Bank account verification method. The default value is `automatic`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#verification_method Subscription#verification_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerificationMethod
        {
            get;
            set;
        }
    }
}
