using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiByValue(fqn: "stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorization")]
    public class IssuingDisputeEvidenceNoValidAuthorization : stripe.IssuingDispute.IIssuingDisputeEvidenceNoValidAuthorization
    {
        /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Additional documentation supporting the dispute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#additional_documentation IssuingDispute#additional_documentation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalDocumentation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalDocumentation
        {
            get;
            set;
        }

        /// <summary>Explanation of why the cardholder is disputing this transaction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#explanation IssuingDispute#explanation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "explanation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Explanation
        {
            get;
            set;
        }
    }
}
