using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiByValue(fqn: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationBacsDebitDisplayPreference")]
    public class PaymentMethodConfigurationBacsDebitDisplayPreference : stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBacsDebitDisplayPreference
    {
        /// <summary>The account's display preference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#preference PaymentMethodConfiguration#preference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Preference
        {
            get;
            set;
        }
    }
}
