using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkSubscriptionData")]
    public class PaymentLinkSubscriptionData : stripe.PaymentLink.IPaymentLinkSubscriptionData
    {
        /// <summary>The subscription's description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#description PaymentLink#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_settings PaymentLink#invoice_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettings\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettings? InvoiceSettings
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on [Subscriptions](https://docs.stripe.com/api/subscriptions) generated from this payment link.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#trial_period_days PaymentLink#trial_period_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrialPeriodDays
        {
            get;
            set;
        }

        /// <summary>Settings related to subscription trials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#trial_settings PaymentLink#trial_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialSettings", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettings\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettings? TrialSettings
        {
            get;
            set;
        }
    }
}
