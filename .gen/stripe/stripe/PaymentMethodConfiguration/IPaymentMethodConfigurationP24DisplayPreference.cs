using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodConfigurationP24DisplayPreference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationP24DisplayPreference")]
    public interface IPaymentMethodConfigurationP24DisplayPreference
    {
        /// <summary>The account's display preference.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodConfigurationP24DisplayPreference), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfigurationP24DisplayPreference")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationP24DisplayPreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account's display preference.</summary>
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
