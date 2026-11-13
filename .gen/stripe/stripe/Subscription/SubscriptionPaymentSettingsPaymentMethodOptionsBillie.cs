using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillie")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillie : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillie
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#company_details Subscription#company_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
        {
            get;
            set;
        }
    }
}
