using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiByValue(fqn: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlipay")]
    public class PaymentMethodConfigurationAlipay : stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlipay
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlipayDisplayPreference\"}", isOptional: true)]
        public stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlipayDisplayPreference? DisplayPreference
        {
            get;
            set;
        }
    }
}
