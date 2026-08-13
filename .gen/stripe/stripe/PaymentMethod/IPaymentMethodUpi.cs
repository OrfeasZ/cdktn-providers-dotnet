using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodUpi), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUpi")]
    public interface IPaymentMethodUpi
    {
        /// <summary>Configuration options for setting up an eMandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#mandate_options PaymentMethod#mandate_options}
        /// </remarks>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpiMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodUpiMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodUpi), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUpi")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodUpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configuration options for setting up an eMandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#mandate_options PaymentMethod#mandate_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpiMandateOptions\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodUpiMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodUpiMandateOptions?>();
            }
        }
    }
}
