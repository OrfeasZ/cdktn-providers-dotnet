using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxElections")]
    public class TaxRegistrationCountryOptionsUsStateSalesTaxElections : stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections
    {
        /// <summary>The type of the election for the state sales tax registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>A [FIPS code](https://www.census.gov/library/reference/code-lists/ansi.html) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Jurisdiction
        {
            get;
            set;
        }
    }
}
