using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsKlarnaSubscriptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptions")]
    public interface IPaymentIntentPaymentMethodOptionsKlarnaSubscriptions
    {
        /// <summary>Unit of time between subscription charges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval PaymentIntent#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>A non-customer-facing reference to correlate subscription charges in the Klarna app. Use a value that persists across subscription charges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#reference PaymentIntent#reference}
        /// </remarks>
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
        string Reference
        {
            get;
        }

        /// <summary>The number of intervals (specified in the `interval` attribute) between subscription charges.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> charges every 3 months.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval_count PaymentIntent#interval_count}
        /// </remarks>
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name for subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#name PaymentIntent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Describes the upcoming charge for this subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#next_billing PaymentIntent#next_billing}
        /// </remarks>
        [JsiiProperty(name: "nextBilling", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling? NextBilling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsKlarnaSubscriptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Unit of time between subscription charges.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval PaymentIntent#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A non-customer-facing reference to correlate subscription charges in the Klarna app. Use a value that persists across subscription charges.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#reference PaymentIntent#reference}
            /// </remarks>
            [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
            public string Reference
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of intervals (specified in the `interval` attribute) between subscription charges.</summary>
            /// <remarks>
            /// For example, <c>interval=month</c> and <c>interval_count=3</c> charges every 3 months.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval_count PaymentIntent#interval_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Name for subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#name PaymentIntent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Describes the upcoming charge for this subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#next_billing PaymentIntent#next_billing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nextBilling", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling? NextBilling
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling?>();
            }
        }
    }
}
