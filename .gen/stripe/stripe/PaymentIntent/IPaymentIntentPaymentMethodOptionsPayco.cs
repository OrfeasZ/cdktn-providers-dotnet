using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsPayco), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPayco")]
    public interface IPaymentIntentPaymentMethodOptionsPayco
    {
        /// <summary>Controls when the funds will be captured from the customer's account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
        /// </remarks>
        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptureMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsPayco), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPayco")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayco
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls when the funds will be captured from the customer's account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptureMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
