using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsRsStandard")]
    public class TaxRegistrationCountryOptionsRsStandard : stripe.TaxRegistration.ITaxRegistrationCountryOptionsRsStandard
    {
        /// <summary>Place of supply scheme used in an standard registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#place_of_supply_scheme TaxRegistration#place_of_supply_scheme}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placeOfSupplyScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlaceOfSupplyScheme
        {
            get;
            set;
        }
    }
}
