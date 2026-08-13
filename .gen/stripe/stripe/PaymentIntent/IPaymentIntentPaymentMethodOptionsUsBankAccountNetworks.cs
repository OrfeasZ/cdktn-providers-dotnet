using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountNetworks), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountNetworks")]
    public interface IPaymentIntentPaymentMethodOptionsUsBankAccountNetworks
    {
        /// <summary>Triggers validations to run across the selected networks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested PaymentIntent#requested}
        /// </remarks>
        [JsiiProperty(name: "requested", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Requested
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountNetworks), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountNetworks")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Triggers validations to run across the selected networks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested PaymentIntent#requested}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requested", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Requested
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
