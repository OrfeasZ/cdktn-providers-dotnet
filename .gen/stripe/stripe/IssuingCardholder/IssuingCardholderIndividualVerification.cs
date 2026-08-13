using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderIndividualVerification")]
    public class IssuingCardholderIndividualVerification : stripe.IssuingCardholder.IIssuingCardholderIndividualVerification
    {
        /// <summary>An identifying document, either a passport or local ID card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#document IssuingCardholder#document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "document", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerificationDocument\"}", isOptional: true)]
        public stripe.IssuingCardholder.IIssuingCardholderIndividualVerificationDocument? Document
        {
            get;
            set;
        }
    }
}
