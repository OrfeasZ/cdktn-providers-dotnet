using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsMx")]
    public class TaxRegistrationCountryOptionsMx : stripe.TaxRegistration.ITaxRegistrationCountryOptionsMx
    {
        /// <summary>Type of registration in `country`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
