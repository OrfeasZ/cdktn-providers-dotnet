using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax")]
    public class TaxRegistrationCountryOptionsUsAttendanceTax : stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax
    {
        /// <summary>A [jurisdiction code](https://docs.stripe.com/tax/registering?type=attendance_tax#registration-types) representing the local jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#jurisdiction TaxRegistration#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public string Jurisdiction
        {
            get;
            set;
        }
    }
}
