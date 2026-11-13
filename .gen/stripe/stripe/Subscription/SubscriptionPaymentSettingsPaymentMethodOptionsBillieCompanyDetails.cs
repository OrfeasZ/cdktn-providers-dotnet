using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registered_address Subscription#registered_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
        {
            get;
            set;
        }

        /// <summary>Company or entity name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registered_name Subscription#registered_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registeredName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegisteredName
        {
            get;
            set;
        }

        /// <summary>The official registration number for the given registration type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registration_number Subscription#registration_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistrationNumber
        {
            get;
            set;
        }

        /// <summary>Type of registration the company or entity holds in their registered country.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registration_type Subscription#registration_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistrationType
        {
            get;
            set;
        }

        /// <summary>VAT ID number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#vat Subscription#vat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vat
        {
            get;
            set;
        }
    }
}
