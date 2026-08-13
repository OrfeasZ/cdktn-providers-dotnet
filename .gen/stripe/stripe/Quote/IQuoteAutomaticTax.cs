using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteAutomaticTax), fullyQualifiedName: "stripe.quote.QuoteAutomaticTax")]
    public interface IQuoteAutomaticTax
    {
        /// <summary>Automatically calculate taxes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#enabled Quote#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The account that's liable for tax.</summary>
        /// <remarks>
        /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#liability Quote#liability}
        /// </remarks>
        [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.quote.QuoteAutomaticTaxLiability\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Quote.IQuoteAutomaticTaxLiability? Liability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteAutomaticTax), fullyQualifiedName: "stripe.quote.QuoteAutomaticTax")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteAutomaticTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Automatically calculate taxes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#enabled Quote#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The account that's liable for tax.</summary>
            /// <remarks>
            /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#liability Quote#liability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.quote.QuoteAutomaticTaxLiability\"}", isOptional: true)]
            public stripe.Quote.IQuoteAutomaticTaxLiability? Liability
            {
                get => GetInstanceProperty<stripe.Quote.IQuoteAutomaticTaxLiability?>();
            }
        }
    }
}
