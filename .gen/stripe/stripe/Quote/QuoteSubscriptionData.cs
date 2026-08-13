using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiByValue(fqn: "stripe.quote.QuoteSubscriptionData")]
    public class QuoteSubscriptionData : stripe.Quote.IQuoteSubscriptionData
    {
        /// <summary>The billing mode of the quote.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#billing_mode Quote#billing_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.quote.QuoteSubscriptionDataBillingMode\"}", isOptional: true)]
        public stripe.Quote.IQuoteSubscriptionDataBillingMode? BillingMode
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on the subscription or subscription schedule when the quote is accepted. If a recurring price is included in `line_items`, this field will be passed to the resulting subscription's `metadata` field. If `subscription_data.effective_date` is used, this field will be passed to the resulting subscription schedule's `phases.metadata` field. Unlike object-level metadata, this field is declarative. Updates will clear prior values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#metadata Quote#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>Integer representing the number of trial period days before the customer is charged for the first time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#trial_period_days Quote#trial_period_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrialPeriodDays
        {
            get;
            set;
        }
    }
}
