using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteSubscriptionDataBillingModeFlexible), fullyQualifiedName: "stripe.quote.QuoteSubscriptionDataBillingModeFlexible")]
    public interface IQuoteSubscriptionDataBillingModeFlexible
    {
        /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#proration_discounts Quote#proration_discounts}
        /// </remarks>
        [JsiiProperty(name: "prorationDiscounts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProrationDiscounts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteSubscriptionDataBillingModeFlexible), fullyQualifiedName: "stripe.quote.QuoteSubscriptionDataBillingModeFlexible")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#proration_discounts Quote#proration_discounts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationDiscounts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationDiscounts
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
