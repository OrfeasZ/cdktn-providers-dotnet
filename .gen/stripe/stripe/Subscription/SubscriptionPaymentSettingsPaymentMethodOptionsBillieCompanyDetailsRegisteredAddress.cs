using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress
    {
        /// <summary>City, district, suburb, town, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#city Subscription#city}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#country Subscription#country}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Country
        {
            get;
            set;
        }

        /// <summary>Address line 1 (for example, street, PO Box, or company name).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#line1 Subscription#line1}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Line1
        {
            get;
            set;
        }

        /// <summary>Address line 2 (for example, apartment, suite, unit, or building).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#line2 Subscription#line2}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#postal_code Subscription#postal_code}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#state Subscription#state}
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
