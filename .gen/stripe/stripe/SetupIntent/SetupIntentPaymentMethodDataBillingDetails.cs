using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetails")]
    public class SetupIntentPaymentMethodDataBillingDetails : stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails
    {
        /// <summary>Billing address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#address SetupIntent#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetailsAddress\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetailsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#email SetupIntent#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>Full name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#name SetupIntent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Billing phone number (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#phone SetupIntent#phone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }

        /// <summary>Taxpayer identification number. Used only for transactions between LATAM buyers and non-LATAM sellers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#tax_id SetupIntent#tax_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxId
        {
            get;
            set;
        }
    }
}
