using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsTr), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsTr")]
    public interface ITaxRegistrationCountryOptionsTr
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

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsTr), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsTr")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsTr
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
        }
    }
}
