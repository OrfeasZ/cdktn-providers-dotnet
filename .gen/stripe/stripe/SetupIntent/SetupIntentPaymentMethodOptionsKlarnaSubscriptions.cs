using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptions")]
    public class SetupIntentPaymentMethodOptionsKlarnaSubscriptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions
    {
        /// <summary>Unit of time between subscription charges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#interval SetupIntent#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Describes the upcoming charge for this subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#next_billing SetupIntent#next_billing}
        /// </remarks>
        [JsiiProperty(name: "nextBilling", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling\"}")]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling NextBilling
        {
            get;
            set;
        }

        /// <summary>A non-customer-facing reference to correlate subscription charges in the Klarna app. Use a value that persists across subscription charges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#reference SetupIntent#reference}
        /// </remarks>
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
        public string Reference
        {
            get;
            set;
        }

        /// <summary>The number of intervals (specified in the `interval` attribute) between subscription charges.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> charges every 3 months.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#interval_count SetupIntent#interval_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalCount
        {
            get;
            set;
        }

        /// <summary>Name for subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#name SetupIntent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
