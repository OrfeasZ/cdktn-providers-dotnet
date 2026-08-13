using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteTransferData), fullyQualifiedName: "stripe.quote.QuoteTransferData")]
    public interface IQuoteTransferData
    {
        /// <summary>The account where funds from the payment will be transferred to upon payment success.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#destination Quote#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>The amount in cents (or local equivalent) that will be transferred to the destination account when the invoice is paid.</summary>
        /// <remarks>
        /// By default, the entire amount is transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#amount Quote#amount}
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

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the destination account. By default, the entire amount will be transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#amount_percent Quote#amount_percent}
        /// </remarks>
        [JsiiProperty(name: "amountPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AmountPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteTransferData), fullyQualifiedName: "stripe.quote.QuoteTransferData")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteTransferData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account where funds from the payment will be transferred to upon payment success.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#destination Quote#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The amount in cents (or local equivalent) that will be transferred to the destination account when the invoice is paid.</summary>
            /// <remarks>
            /// By default, the entire amount is transferred to the destination.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#amount Quote#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
            /// <remarks>
            /// This represents the percentage of the subscription invoice total that will be transferred to the destination account. By default, the entire amount will be transferred to the destination.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#amount_percent Quote#amount_percent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AmountPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
