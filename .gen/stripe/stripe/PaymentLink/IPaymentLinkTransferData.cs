using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkTransferData), fullyQualifiedName: "stripe.paymentLink.PaymentLinkTransferData")]
    public interface IPaymentLinkTransferData
    {
        /// <summary>The connected account receiving the transfer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#destination PaymentLink#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>The amount in cents (or local equivalent) that will be transferred to the destination account.</summary>
        /// <remarks>
        /// By default, the entire amount is transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#amount PaymentLink#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkTransferData), fullyQualifiedName: "stripe.paymentLink.PaymentLinkTransferData")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkTransferData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The connected account receiving the transfer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#destination PaymentLink#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The amount in cents (or local equivalent) that will be transferred to the destination account.</summary>
            /// <remarks>
            /// By default, the entire amount is transferred to the destination.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#amount PaymentLink#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
