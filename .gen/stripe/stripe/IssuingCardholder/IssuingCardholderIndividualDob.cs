using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderIndividualDob")]
    public class IssuingCardholderIndividualDob : stripe.IssuingCardholder.IIssuingCardholderIndividualDob
    {
        /// <summary>The day of birth, between 1 and 31.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#day IssuingCardholder#day}
        /// </remarks>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}")]
        public double Day
        {
            get;
            set;
        }

        /// <summary>The month of birth, between 1 and 12.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#month IssuingCardholder#month}
        /// </remarks>
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}")]
        public double Month
        {
            get;
            set;
        }

        /// <summary>The four-digit year of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#year IssuingCardholder#year}
        /// </remarks>
        [JsiiProperty(name: "year", typeJson: "{\"primitive\":\"number\"}")]
        public double Year
        {
            get;
            set;
        }
    }
}
