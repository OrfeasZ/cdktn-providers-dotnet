using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiByValue(fqn: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationCustomerBalance")]
    public class PaymentMethodConfigurationCustomerBalance : stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCustomerBalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCustomerBalanceDisplayPreference\"}", isOptional: true)]
        public stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCustomerBalanceDisplayPreference? DisplayPreference
        {
            get;
            set;
        }
    }
}
