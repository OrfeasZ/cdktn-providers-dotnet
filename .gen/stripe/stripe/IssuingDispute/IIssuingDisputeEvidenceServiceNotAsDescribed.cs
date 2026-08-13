using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiInterface(nativeType: typeof(IIssuingDisputeEvidenceServiceNotAsDescribed), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribed")]
    public interface IIssuingDisputeEvidenceServiceNotAsDescribed
    {
        /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Additional documentation supporting the dispute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#additional_documentation IssuingDispute#additional_documentation}
        /// </remarks>
        [JsiiProperty(name: "additionalDocumentation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalDocumentation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date when order was canceled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#canceled_at IssuingDispute#canceled_at}
        /// </remarks>
        [JsiiProperty(name: "canceledAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CanceledAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Reason for canceling the order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cancellation_reason IssuingDispute#cancellation_reason}
        /// </remarks>
        [JsiiProperty(name: "cancellationReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CancellationReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Explanation of why the cardholder is disputing this transaction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#explanation IssuingDispute#explanation}
        /// </remarks>
        [JsiiProperty(name: "explanation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Explanation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date when the product was received.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#received_at IssuingDispute#received_at}
        /// </remarks>
        [JsiiProperty(name: "receivedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReceivedAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingDisputeEvidenceServiceNotAsDescribed), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribed")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingDispute.IIssuingDisputeEvidenceServiceNotAsDescribed
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Additional documentation supporting the dispute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#additional_documentation IssuingDispute#additional_documentation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalDocumentation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalDocumentation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date when order was canceled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#canceled_at IssuingDispute#canceled_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canceledAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CanceledAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Reason for canceling the order.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cancellation_reason IssuingDispute#cancellation_reason}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cancellationReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CancellationReason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Explanation of why the cardholder is disputing this transaction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#explanation IssuingDispute#explanation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "explanation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Explanation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date when the product was received.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#received_at IssuingDispute#received_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "receivedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReceivedAt
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
