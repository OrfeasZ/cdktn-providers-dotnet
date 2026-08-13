using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsBs), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsBs")]
    public interface ITaxRegistrationCountryOptionsBs
    {
        /// <summary>Type of registration in `country`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Options for the standard registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#standard TaxRegistration#standard}
        /// </remarks>
        [JsiiProperty(name: "standard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsBsStandard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsBsStandard? Standard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsBs), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsBs")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsBs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of registration in `country`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Options for the standard registration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#standard TaxRegistration#standard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "standard", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsBsStandard\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsBsStandard? Standard
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsBsStandard?>();
            }
        }
    }
}
