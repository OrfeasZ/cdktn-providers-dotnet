using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsUs")]
    public class TaxRegistrationCountryOptionsUs : stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs
    {
        /// <summary>Two-letter US state code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#state TaxRegistration#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }

        /// <summary>Type of registration in the US.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#local_amusement_tax TaxRegistration#local_amusement_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax? LocalAmusementTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#local_lease_tax TaxRegistration#local_lease_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax? LocalLeaseTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#state_sales_tax TaxRegistration#state_sales_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax? StateSalesTax
        {
            get;
            set;
        }
    }
}
