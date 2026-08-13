using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsBbStandard), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsBbStandard")]
    public interface ITaxRegistrationCountryOptionsBbStandard
    {
        /// <summary>Place of supply scheme used in an standard registration.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsBbStandard), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsBbStandard")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsBbStandard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Place of supply scheme used in an standard registration.</summary>
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
