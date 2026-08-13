using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteSubscriptionData), fullyQualifiedName: "stripe.quote.QuoteSubscriptionData")]
    public interface IQuoteSubscriptionData
    {
        /// <summary>The billing mode of the quote.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#billing_mode Quote#billing_mode}
        /// </remarks>
        [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingMode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Quote.IQuoteSubscriptionDataBillingMode? BillingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The subscription's description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#description Quote#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>When creating a new subscription, the date of which the subscription schedule will start after the quote is accepted.</summary>
        /// <remarks>
        /// This date is ignored if it is in the past when the quote is accepted. Measured in seconds since the Unix epoch.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#effective_date Quote#effective_date}
        /// </remarks>
        [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EffectiveDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on the subscription or subscription schedule when the quote is accepted. If a recurring price is included in `line_items`, this field will be passed to the resulting subscription's `metadata` field. If `subscription_data.effective_date` is used, this field will be passed to the resulting subscription schedule's `phases.metadata` field. Unlike object-level metadata, this field is declarative. Updates will clear prior values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#metadata Quote#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Integer representing the number of trial period days before the customer is charged for the first time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#trial_period_days Quote#trial_period_days}
        /// </remarks>
        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrialPeriodDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteSubscriptionData), fullyQualifiedName: "stripe.quote.QuoteSubscriptionData")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteSubscriptionData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The billing mode of the quote.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#billing_mode Quote#billing_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingMode\"}", isOptional: true)]
            public stripe.Quote.IQuoteSubscriptionDataBillingMode? BillingMode
            {
                get => GetInstanceProperty<stripe.Quote.IQuoteSubscriptionDataBillingMode?>();
            }

            /// <summary>The subscription's description, meant to be displayable to the customer.</summary>
            /// <remarks>
            /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#description Quote#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When creating a new subscription, the date of which the subscription schedule will start after the quote is accepted.</summary>
            /// <remarks>
            /// This date is ignored if it is in the past when the quote is accepted. Measured in seconds since the Unix epoch.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#effective_date Quote#effective_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EffectiveDate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on the subscription or subscription schedule when the quote is accepted. If a recurring price is included in `line_items`, this field will be passed to the resulting subscription's `metadata` field. If `subscription_data.effective_date` is used, this field will be passed to the resulting subscription schedule's `phases.metadata` field. Unlike object-level metadata, this field is declarative. Updates will clear prior values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#metadata Quote#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Integer representing the number of trial period days before the customer is charged for the first time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#trial_period_days Quote#trial_period_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrialPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
