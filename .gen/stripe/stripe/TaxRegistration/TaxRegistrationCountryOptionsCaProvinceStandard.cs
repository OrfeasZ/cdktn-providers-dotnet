using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsCaProvinceStandard")]
    public class TaxRegistrationCountryOptionsCaProvinceStandard : stripe.TaxRegistration.ITaxRegistrationCountryOptionsCaProvinceStandard
    {
        /// <summary>Two-letter CA province code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#province TaxRegistration#province}
        /// </remarks>
        [JsiiProperty(name: "province", typeJson: "{\"primitive\":\"string\"}")]
        public string Province
        {
            get;
            set;
        }
    }
}
