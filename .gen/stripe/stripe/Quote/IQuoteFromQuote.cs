using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteFromQuote), fullyQualifiedName: "stripe.quote.QuoteFromQuote")]
    public interface IQuoteFromQuote
    {
        /// <summary>The quote that was cloned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#quote Quote#quote}
        /// </remarks>
        [JsiiProperty(name: "quote", typeJson: "{\"primitive\":\"string\"}")]
        string Quote
        {
            get;
        }

        /// <summary>Whether this quote is a revision of a different quote.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#is_revision Quote#is_revision}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRevision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRevision
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteFromQuote), fullyQualifiedName: "stripe.quote.QuoteFromQuote")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteFromQuote
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The quote that was cloned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#quote Quote#quote}
            /// </remarks>
            [JsiiProperty(name: "quote", typeJson: "{\"primitive\":\"string\"}")]
            public string Quote
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether this quote is a revision of a different quote.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#is_revision Quote#is_revision}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRevision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRevision
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
