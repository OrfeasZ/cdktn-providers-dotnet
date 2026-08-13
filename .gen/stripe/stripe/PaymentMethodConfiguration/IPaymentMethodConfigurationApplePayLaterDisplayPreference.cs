using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodConfigurationApplePayLaterDisplayPreference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePayLaterDisplayPreference")]
    public interface IPaymentMethodConfigurationApplePayLaterDisplayPreference
    {
        /// <summary>The account's preference for whether or not to display this payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#preference PaymentMethodConfiguration#preference}
        /// </remarks>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Preference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodConfigurationApplePayLaterDisplayPreference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePayLaterDisplayPreference")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePayLaterDisplayPreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account's preference for whether or not to display this payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#preference PaymentMethodConfiguration#preference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Preference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
