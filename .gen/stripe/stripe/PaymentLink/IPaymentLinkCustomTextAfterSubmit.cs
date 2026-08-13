using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkCustomTextAfterSubmit), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomTextAfterSubmit")]
    public interface IPaymentLinkCustomTextAfterSubmit
    {
        /// <summary>Text can be up to 1200 characters in length.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#message PaymentLink#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        string Message
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkCustomTextAfterSubmit), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomTextAfterSubmit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Text can be up to 1200 characters in length.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#message PaymentLink#message}
            /// </remarks>
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
            public string Message
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
