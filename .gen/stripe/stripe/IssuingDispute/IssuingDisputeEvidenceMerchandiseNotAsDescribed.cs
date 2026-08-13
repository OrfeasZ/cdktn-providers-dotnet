using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiByValue(fqn: "stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribed")]
    public class IssuingDisputeEvidenceMerchandiseNotAsDescribed : stripe.IssuingDispute.IIssuingDisputeEvidenceMerchandiseNotAsDescribed
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

        /// <summary>Date when the product was received.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#received_at IssuingDispute#received_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "receivedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReceivedAt
        {
            get;
            set;
        }

        /// <summary>Description of the cardholder's attempt to return the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#return_description IssuingDispute#return_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReturnDescription
        {
            get;
            set;
        }

        /// <summary>Date when the product was returned or attempted to be returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#returned_at IssuingDispute#returned_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReturnedAt
        {
            get;
            set;
        }

        /// <summary>Result of cardholder's attempt to return the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#return_status IssuingDispute#return_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReturnStatus
        {
            get;
            set;
        }
    }
}
