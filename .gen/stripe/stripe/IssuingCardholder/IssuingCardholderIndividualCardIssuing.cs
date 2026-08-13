using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing")]
    public class IssuingCardholderIndividualCardIssuing : stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing
    {
        /// <summary>Information about cardholder acceptance of Celtic [Authorized User Terms](https://stripe.com/docs/issuing/cards#accept-authorized-user-terms). Required for cards backed by a Celtic program.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#user_terms_acceptance IssuingCardholder#user_terms_acceptance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userTermsAcceptance", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptance\"}", isOptional: true)]
        public stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuingUserTermsAcceptance? UserTermsAcceptance
        {
            get;
            set;
        }
    }
}
