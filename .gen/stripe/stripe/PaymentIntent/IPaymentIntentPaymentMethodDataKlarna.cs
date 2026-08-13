using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataKlarna), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna")]
    public interface IPaymentIntentPaymentMethodDataKlarna
    {
        /// <summary>Customer's date of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#dob PaymentIntent#dob}
        /// </remarks>
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarnaDob\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarnaDob? Dob
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataKlarna), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Customer's date of birth.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#dob PaymentIntent#dob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarnaDob\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarnaDob? Dob
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarnaDob?>();
            }
        }
    }
}
