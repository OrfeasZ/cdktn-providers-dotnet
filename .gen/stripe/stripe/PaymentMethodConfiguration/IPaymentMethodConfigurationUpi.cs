using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodConfigurationUpi), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpi")]
    public interface IPaymentMethodConfigurationUpi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
        [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpiDisplayPreference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpiDisplayPreference? DisplayPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodConfigurationUpi), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpi")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#display_preference PaymentMethodConfiguration#display_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayPreference", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpiDisplayPreference\"}", isOptional: true)]
            public stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpiDisplayPreference? DisplayPreference
            {
                get => GetInstanceProperty<stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpiDisplayPreference?>();
            }
        }
    }
}
