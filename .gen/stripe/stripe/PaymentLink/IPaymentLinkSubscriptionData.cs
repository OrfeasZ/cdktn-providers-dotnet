using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkSubscriptionData), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionData")]
    public interface IPaymentLinkSubscriptionData
    {
        /// <summary>The subscription's description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#description PaymentLink#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_settings PaymentLink#invoice_settings}.</summary>
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettings? InvoiceSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on [Subscriptions](https://docs.stripe.com/api/subscriptions) generated from this payment link.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#trial_period_days PaymentLink#trial_period_days}
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

        /// <summary>Settings related to subscription trials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#trial_settings PaymentLink#trial_settings}
        /// </remarks>
        [JsiiProperty(name: "trialSettings", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettings? TrialSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkSubscriptionData), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionData")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkSubscriptionData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_settings PaymentLink#invoice_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettings\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettings? InvoiceSettings
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettings?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on [Subscriptions](https://docs.stripe.com/api/subscriptions) generated from this payment link.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Integer representing the number of trial period days before the customer is charged for the first time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#trial_period_days PaymentLink#trial_period_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrialPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Settings related to subscription trials.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#trial_settings PaymentLink#trial_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialSettings", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataTrialSettings\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettings? TrialSettings
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkSubscriptionDataTrialSettings?>();
            }
        }
    }
}
