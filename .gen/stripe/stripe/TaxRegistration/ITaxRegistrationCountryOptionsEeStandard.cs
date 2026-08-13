using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsEeStandard), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsEeStandard")]
    public interface ITaxRegistrationCountryOptionsEeStandard
    {
        /// <summary>Place of supply scheme used in an EU standard registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#place_of_supply_scheme TaxRegistration#place_of_supply_scheme}
        /// </remarks>
        [JsiiProperty(name: "placeOfSupplyScheme", typeJson: "{\"primitive\":\"string\"}")]
        string PlaceOfSupplyScheme
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsEeStandard), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsEeStandard")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsEeStandard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Place of supply scheme used in an EU standard registration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#place_of_supply_scheme TaxRegistration#place_of_supply_scheme}
            /// </remarks>
            [JsiiProperty(name: "placeOfSupplyScheme", typeJson: "{\"primitive\":\"string\"}")]
            public string PlaceOfSupplyScheme
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
