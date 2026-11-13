using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUsAttendanceTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax")]
    public interface ITaxRegistrationCountryOptionsUsAttendanceTax
    {
        /// <summary>A [jurisdiction code](https://docs.stripe.com/tax/registering?type=attendance_tax#registration-types) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        string Jurisdiction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsUsAttendanceTax), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A [jurisdiction code](https://docs.stripe.com/tax/registering?type=attendance_tax#registration-types) representing the local jurisdiction.</summary>
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
