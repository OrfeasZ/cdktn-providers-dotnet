using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptance")]
    public class IssuingCardholderIndividualCardIssuingUserTermsAcceptance : stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuingUserTermsAcceptance
    {
        /// <summary>The Unix timestamp marking when the cardholder accepted the Authorized User Terms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#date IssuingCardholder#date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Date
        {
            get;
            set;
        }

        /// <summary>The IP address from which the cardholder accepted the Authorized User Terms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#ip IssuingCardholder#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        /// <summary>The user agent of the browser from which the cardholder accepted the Authorized User Terms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#user_agent IssuingCardholder#user_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAgent
        {
            get;
            set;
        }
    }
}
