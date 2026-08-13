using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUsStateSalesTaxElections), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxElections")]
    public interface ITaxRegistrationCountryOptionsUsStateSalesTaxElections
    {
        /// <summary>The type of the election for the state sales tax registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>A [FIPS code](https://www.census.gov/library/reference/code-lists/ansi.html) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jurisdiction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsUsStateSalesTaxElections), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxElections")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of the election for the state sales tax registration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A [FIPS code](https://www.census.gov/library/reference/code-lists/ansi.html) representing the local jurisdiction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
