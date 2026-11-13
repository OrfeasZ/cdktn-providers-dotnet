using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPix")]
    public class PaymentIntentPaymentMethodOptionsPix : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPix
    {
        /// <summary>Determines if the amount includes the IOF tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#amount_includes_iof PaymentIntent#amount_includes_iof}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountIncludesIof
        {
            get;
            set;
        }

        /// <summary>The number of seconds after PaymentIntent confirmation when the Pix expires (between 60 and 1209600, inclusive).</summary>
        /// <remarks>
        /// If neither expiration option is supplied, defaults to 14400 seconds (4 hours). Mutually exclusive with <c>expires_at</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#expires_after_seconds PaymentIntent#expires_after_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAfterSeconds
        {
            get;
            set;
        }

        /// <summary>The absolute Unix timestamp at which the Pix expires.</summary>
        /// <remarks>
        /// When supplied as an input, it must be between 60 and 1209600 seconds from the current time at validation, inclusive. If neither expiration option is supplied, the Pix expires 14400 seconds (4 hours) after PaymentIntent confirmation. Mutually exclusive with <c>expires_after_seconds</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#expires_at PaymentIntent#expires_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#mandate_options PaymentIntent#mandate_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPixMandateOptions\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPixMandateOptions? MandateOptions
        {
            get;
            set;
        }

        /// <summary>Indicates that you intend to make future payments with this PaymentIntent's payment method.</summary>
        /// <remarks>
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a href="/payments/save-during-payment">attach the payment method</a> to the Customer after the PaymentIntent is confirmed and the customer completes any required actions. If you don't provide a Customer, you can still <a href="/api/payment_methods/attach">attach</a> the payment method to a Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates and attaches a <a href="/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply with regional legislation and network rules, such as <a href="/strong-customer-authentication">SCA</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetupFutureUsage
        {
            get;
            set;
        }
    }
}
