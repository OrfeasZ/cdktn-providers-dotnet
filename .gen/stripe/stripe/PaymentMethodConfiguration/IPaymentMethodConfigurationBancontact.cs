using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodConfigurationBancontact), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontact")]
    public interface IPaymentMethodConfigurationBancontact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontactDisplayPreference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontactDisplayPreference? DisplayPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodConfigurationBancontact), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontact")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontactDisplayPreference\"}", isOptional: true)]
            public stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontactDisplayPreference? DisplayPreference
            {
                get => GetInstanceProperty<stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontactDisplayPreference?>();
            }
        }
    }
}
