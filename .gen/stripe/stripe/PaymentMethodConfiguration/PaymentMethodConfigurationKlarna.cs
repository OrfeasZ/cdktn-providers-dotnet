using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiByValue(fqn: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarna")]
    public class PaymentMethodConfigurationKlarna : stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarnaDisplayPreference\"}", isOptional: true)]
        public stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarnaDisplayPreference? DisplayPreference
        {
            get;
            set;
        }
    }
}
