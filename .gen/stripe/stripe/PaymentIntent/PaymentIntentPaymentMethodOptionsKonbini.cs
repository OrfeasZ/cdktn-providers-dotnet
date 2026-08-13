using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKonbini")]
    public class PaymentIntentPaymentMethodOptionsKonbini : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKonbini
    {
        /// <summary>An optional 10 to 11 digit numeric-only string determining the confirmation code at applicable convenience stores.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#confirmation_number PaymentIntent#confirmation_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfirmationNumber
        {
            get;
            set;
        }

        /// <summary>The number of calendar days (between 1 and 60) after which Konbini payment instructions will expire.</summary>
        /// <remarks>
        /// For example, if a PaymentIntent is confirmed with Konbini and <c>expires_after_days</c> set to 2 on Monday JST, the instructions will expire on Wednesday 23:59:59 JST.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#expires_after_days PaymentIntent#expires_after_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAfterDays
        {
            get;
            set;
        }

        /// <summary>The timestamp at which the Konbini payment instructions will expire. Only one of `expires_after_days` or `expires_at` may be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#expires_at PaymentIntent#expires_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAt
        {
            get;
            set;
        }

        /// <summary>A product descriptor of up to 22 characters, which will appear to customers at the convenience store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#product_description PaymentIntent#product_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductDescription
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
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
