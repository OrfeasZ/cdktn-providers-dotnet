using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardPresentRouting), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardPresentRouting")]
    public interface IPaymentIntentPaymentMethodOptionsCardPresentRouting
    {
        /// <summary>Requested routing priority.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested_priority PaymentIntent#requested_priority}
        /// </remarks>
        [JsiiProperty(name: "requestedPriority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestedPriority
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardPresentRouting), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardPresentRouting")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardPresentRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Requested routing priority.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requested_priority PaymentIntent#requested_priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestedPriority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestedPriority
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
