using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUsLuxuryTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax")]
    public interface ITaxRegistrationCountryOptionsUsLuxuryTax
    {
        /// <summary>A [jurisdiction code](https://docs.stripe.com/tax/registering?type=luxury_tax#registration-types) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        string Jurisdiction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsUsLuxuryTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A [jurisdiction code](https://docs.stripe.com/tax/registering?type=luxury_tax#registration-types) representing the local jurisdiction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
            /// </remarks>
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
            public string Jurisdiction
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
