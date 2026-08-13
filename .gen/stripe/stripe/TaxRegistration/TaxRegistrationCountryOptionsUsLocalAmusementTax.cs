using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax")]
    public class TaxRegistrationCountryOptionsUsLocalAmusementTax : stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax
    {
        /// <summary>A [FIPS code](https://www.census.gov/library/reference/code-lists/ansi.html) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public string Jurisdiction
        {
            get;
            set;
        }
    }
}
