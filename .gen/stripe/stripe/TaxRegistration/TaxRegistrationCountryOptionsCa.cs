using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsCa")]
    public class TaxRegistrationCountryOptionsCa : stripe.TaxRegistration.ITaxRegistrationCountryOptionsCa
    {
        /// <summary>Type of registration in Canada.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#province_standard TaxRegistration#province_standard}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provinceStandard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsCaProvinceStandard\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsCaProvinceStandard? ProvinceStandard
        {
            get;
            set;
        }
    }
}
