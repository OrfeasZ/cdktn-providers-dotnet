using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkAfterCompletionRedirect), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletionRedirect")]
    public interface IPaymentLinkAfterCompletionRedirect
    {
        /// <summary>The URL the customer will be redirected to after the purchase is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#url PaymentLink#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkAfterCompletionRedirect), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletionRedirect")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The URL the customer will be redirected to after the purchase is complete.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#url PaymentLink#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
