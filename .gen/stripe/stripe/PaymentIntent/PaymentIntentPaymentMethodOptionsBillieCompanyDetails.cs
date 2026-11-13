using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetails")]
    public class PaymentIntentPaymentMethodOptionsBillieCompanyDetails : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registered_address PaymentIntent#registered_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
        {
            get;
            set;
        }

        /// <summary>Company or entity name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registered_name PaymentIntent#registered_name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registration_number PaymentIntent#registration_number}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registration_type PaymentIntent#registration_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistrationType
        {
            get;
            set;
        }

        /// <summary>VAT id number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#vat PaymentIntent#vat}
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
