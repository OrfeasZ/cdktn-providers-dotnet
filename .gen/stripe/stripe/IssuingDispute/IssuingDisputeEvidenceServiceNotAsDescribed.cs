using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiByValue(fqn: "stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribed")]
    public class IssuingDisputeEvidenceServiceNotAsDescribed : stripe.IssuingDispute.IIssuingDisputeEvidenceServiceNotAsDescribed
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

        /// <summary>Date when order was canceled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#canceled_at IssuingDispute#canceled_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "canceledAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CanceledAt
        {
            get;
            set;
        }

        /// <summary>Reason for canceling the order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cancellation_reason IssuingDispute#cancellation_reason}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cancellationReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CancellationReason
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
    }
}
