using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsNzStandard), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsNzStandard")]
    public interface ITaxRegistrationCountryOptionsNzStandard
    {
        /// <summary>Place of supply scheme used in an Default standard registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#place_of_supply_scheme TaxRegistration#place_of_supply_scheme}
        /// </remarks>
        [JsiiProperty(name: "placeOfSupplyScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlaceOfSupplyScheme
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsNzStandard), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsNzStandard")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsNzStandard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Place of supply scheme used in an Default standard registration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#place_of_supply_scheme TaxRegistration#place_of_supply_scheme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placeOfSupplyScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlaceOfSupplyScheme
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
