using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkAfterCompletionHostedConfirmation), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation")]
    public interface IPaymentLinkAfterCompletionHostedConfirmation
    {
        /// <summary>The custom message that is displayed to the customer after the purchase is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_message PaymentLink#custom_message}
        /// </remarks>
        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkAfterCompletionHostedConfirmation), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The custom message that is displayed to the customer after the purchase is complete.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_message PaymentLink#custom_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomMessage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
