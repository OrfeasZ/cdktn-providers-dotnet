using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodKlarna), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodKlarna")]
    public interface IPaymentMethodKlarna
    {
        /// <summary>The customer's date of birth, if provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#dob PaymentMethod#dob}
        /// </remarks>
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarnaDob\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodKlarnaDob? Dob
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodKlarna), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodKlarna")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodKlarna
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's date of birth, if provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#dob PaymentMethod#dob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarnaDob\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodKlarnaDob? Dob
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodKlarnaDob?>();
            }
        }
    }
}
