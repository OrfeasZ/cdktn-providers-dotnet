using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemand")]
    public class SetupIntentPaymentMethodOptionsKlarnaOnDemand : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand
    {
        /// <summary>Your average amount value.</summary>
        /// <remarks>
        /// You can use a value across your customer base, or segment based on customer type, country, etc.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#average_amount SetupIntent#average_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "averageAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AverageAmount
        {
            get;
            set;
        }

        /// <summary>The maximum value you may charge a customer per purchase.</summary>
        /// <remarks>
        /// You can use a value across your customer base, or segment based on customer type, country, etc.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#maximum_amount SetupIntent#maximum_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumAmount
        {
            get;
            set;
        }

        /// <summary>The lowest or minimum value you may charge a customer per purchase.</summary>
        /// <remarks>
        /// You can use a value across your customer base, or segment based on customer type, country, etc.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#minimum_amount SetupIntent#minimum_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumAmount
        {
            get;
            set;
        }

        /// <summary>Interval at which the customer is making purchases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#purchase_interval SetupIntent#purchase_interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "purchaseInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PurchaseInterval
        {
            get;
            set;
        }

        /// <summary>The number of `purchase_interval` between charges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#purchase_interval_count SetupIntent#purchase_interval_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "purchaseIntervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PurchaseIntervalCount
        {
            get;
            set;
        }
    }
}
