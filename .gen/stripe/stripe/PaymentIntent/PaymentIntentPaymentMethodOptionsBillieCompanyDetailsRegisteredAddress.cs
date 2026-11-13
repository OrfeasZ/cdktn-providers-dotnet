using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress")]
    public class PaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress
    {
        /// <summary>City, district, suburb, town, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#city PaymentIntent#city}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? City
        {
            get;
            set;
        }

        /// <summary>Two-letter country code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#country PaymentIntent#country}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Country
        {
            get;
            set;
        }

        /// <summary>Address line 1 (e.g., street, PO Box, or company name).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#line1 PaymentIntent#line1}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Line1
        {
            get;
            set;
        }

        /// <summary>Address line 2 (e.g., apartment, suite, unit, or building).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#line2 PaymentIntent#line2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Line2
        {
            get;
            set;
        }

        /// <summary>ZIP or postal code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#postal_code PaymentIntent#postal_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostalCode
        {
            get;
            set;
        }

        /// <summary>State, county, province, or region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#state PaymentIntent#state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }
    }
}
