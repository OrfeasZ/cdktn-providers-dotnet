using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodCard")]
    public class PaymentMethodCard : stripe.PaymentMethod.IPaymentMethodCard
    {
        /// <summary>The card's CVC. It is highly recommended to always include this value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#cvc PaymentMethod#cvc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cvc
        {
            get;
            set;
        }

        /// <summary>Two-digit number representing the card's expiration month.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#exp_month PaymentMethod#exp_month}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpMonth
        {
            get;
            set;
        }

        /// <summary>Four-digit number representing the card's expiration year.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#exp_year PaymentMethod#exp_year}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpYear
        {
            get;
            set;
        }

        /// <summary>Contains information about card networks that can be used to process the payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#networks PaymentMethod#networks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardNetworks\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodCardNetworks? Networks
        {
            get;
            set;
        }

        /// <summary>The card number, as a string without any separators.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#number PaymentMethod#number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Number
        {
            get;
            set;
        }

        /// <summary>For backwards compatibility, you can alternatively provide a Stripe token (e.g., for Apple Pay, Amex Express Checkout, or legacy Checkout) into the card hash with format card: {token: "tok_visa"}.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#token PaymentMethod#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}
