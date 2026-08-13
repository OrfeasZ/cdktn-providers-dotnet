using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderIndividual")]
    public class IssuingCardholderIndividual : stripe.IssuingCardholder.IIssuingCardholderIndividual
    {
        /// <summary>Information related to the card_issuing program for this cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#card_issuing IssuingCardholder#card_issuing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing\"}", isOptional: true)]
        public stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing? CardIssuing
        {
            get;
            set;
        }

        /// <summary>The date of birth of this cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#dob IssuingCardholder#dob}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualDob\"}", isOptional: true)]
        public stripe.IssuingCardholder.IIssuingCardholderIndividualDob? Dob
        {
            get;
            set;
        }

        /// <summary>The first name of this cardholder.</summary>
        /// <remarks>
        /// Required before activating Cards. This field cannot contain any numbers, special characters (except periods, commas, hyphens, spaces and apostrophes) or non-latin letters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#first_name IssuingCardholder#first_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>The last name of this cardholder.</summary>
        /// <remarks>
        /// Required before activating Cards. This field cannot contain any numbers, special characters (except periods, commas, hyphens, spaces and apostrophes) or non-latin letters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#last_name IssuingCardholder#last_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastName
        {
            get;
            set;
        }

        /// <summary>Government-issued ID document for this cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#verification IssuingCardholder#verification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verification", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerification\"}", isOptional: true)]
        public stripe.IssuingCardholder.IIssuingCardholderIndividualVerification? Verification
        {
            get;
            set;
        }
    }
}
