using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUsStateSalesTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax")]
    public interface ITaxRegistrationCountryOptionsUsStateSalesTax
    {
        /// <summary>Elections for the state sales tax registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#elections TaxRegistration#elections}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "elections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxElections\"},\"kind\":\"array\"}}]}}")]
        object Elections
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsUsStateSalesTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Elections for the state sales tax registration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#elections TaxRegistration#elections}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "elections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxElections\"},\"kind\":\"array\"}}]}}")]
            public object Elections
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
