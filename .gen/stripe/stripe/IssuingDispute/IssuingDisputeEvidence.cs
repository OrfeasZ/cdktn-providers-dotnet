using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiByValue(fqn: "stripe.issuingDispute.IssuingDisputeEvidence")]
    public class IssuingDisputeEvidence : stripe.IssuingDispute.IIssuingDisputeEvidence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#canceled IssuingDispute#canceled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "canceled", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceCanceled\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceCanceled? Canceled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#duplicate IssuingDispute#duplicate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duplicate", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceDuplicate\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceDuplicate? Duplicate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#fraudulent IssuingDispute#fraudulent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fraudulent", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceFraudulent\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceFraudulent? Fraudulent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#merchandise_not_as_described IssuingDispute#merchandise_not_as_described}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "merchandiseNotAsDescribed", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribed\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceMerchandiseNotAsDescribed? MerchandiseNotAsDescribed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#not_received IssuingDispute#not_received}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notReceived", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNotReceived\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceNotReceived? NotReceived
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#no_valid_authorization IssuingDispute#no_valid_authorization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noValidAuthorization", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorization\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceNoValidAuthorization? NoValidAuthorization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#other IssuingDispute#other}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "other", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceOther\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceOther? Other
        {
            get;
            set;
        }

        /// <summary>The reason for filing the dispute. Its value will match the field containing the evidence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#reason IssuingDispute#reason}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#service_not_as_described IssuingDispute#service_not_as_described}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceNotAsDescribed", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribed\"}", isOptional: true)]
        public stripe.IssuingDispute.IIssuingDisputeEvidenceServiceNotAsDescribed? ServiceNotAsDescribed
        {
            get;
            set;
        }
    }
}
