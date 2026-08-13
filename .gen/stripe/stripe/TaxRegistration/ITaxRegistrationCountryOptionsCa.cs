using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsCa), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsCa")]
    public interface ITaxRegistrationCountryOptionsCa
    {
        /// <summary>Type of registration in Canada.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#province_standard TaxRegistration#province_standard}.</summary>
        [JsiiProperty(name: "provinceStandard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsCaProvinceStandard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsCaProvinceStandard? ProvinceStandard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsCa), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsCa")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsCa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of registration in Canada.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#province_standard TaxRegistration#province_standard}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provinceStandard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsCaProvinceStandard\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsCaProvinceStandard? ProvinceStandard
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsCaProvinceStandard?>();
            }
        }
    }
}
