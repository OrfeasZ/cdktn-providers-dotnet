using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteSubscriptionDataBillingMode), fullyQualifiedName: "stripe.quote.QuoteSubscriptionDataBillingMode")]
    public interface IQuoteSubscriptionDataBillingMode
    {
        /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#type Quote#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#flexible Quote#flexible}.</summary>
        [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingModeFlexible\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible? Flexible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteSubscriptionDataBillingMode), fullyQualifiedName: "stripe.quote.QuoteSubscriptionDataBillingMode")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteSubscriptionDataBillingMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how prorations and invoices for subscriptions are calculated and orchestrated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#type Quote#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#flexible Quote#flexible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flexible", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingModeFlexible\"}", isOptional: true)]
            public stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible? Flexible
            {
                get => GetInstanceProperty<stripe.Quote.IQuoteSubscriptionDataBillingModeFlexible?>();
            }
        }
    }
}
