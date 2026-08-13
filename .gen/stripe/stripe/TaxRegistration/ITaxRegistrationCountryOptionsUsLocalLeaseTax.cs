using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUsLocalLeaseTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax")]
    public interface ITaxRegistrationCountryOptionsUsLocalLeaseTax
    {
        /// <summary>A [FIPS code](https://www.census.gov/library/reference/code-lists/ansi.html) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        string Jurisdiction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsUsLocalLeaseTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A [FIPS code](https://www.census.gov/library/reference/code-lists/ansi.html) representing the local jurisdiction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
            /// </remarks>
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
            public string Jurisdiction
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
