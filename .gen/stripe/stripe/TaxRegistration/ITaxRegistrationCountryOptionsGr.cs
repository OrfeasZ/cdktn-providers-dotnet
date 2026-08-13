using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsGr), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsGr")]
    public interface ITaxRegistrationCountryOptionsGr
    {
        /// <summary>Type of registration in an EU country.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#standard TaxRegistration#standard}.</summary>
        [JsiiProperty(name: "standard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsGrStandard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsGrStandard? Standard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsGr), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsGr")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsGr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of registration in an EU country.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#standard TaxRegistration#standard}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "standard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsGrStandard\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsGrStandard? Standard
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsGrStandard?>();
            }
        }
    }
}
