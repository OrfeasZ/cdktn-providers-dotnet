using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiInterface(nativeType: typeof(IIssuingDisputeEvidenceNoValidAuthorization), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorization")]
    public interface IIssuingDisputeEvidenceNoValidAuthorization
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

        [JsiiTypeProxy(nativeType: typeof(IIssuingDisputeEvidenceNoValidAuthorization), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorization")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingDispute.IIssuingDisputeEvidenceNoValidAuthorization
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
        }
    }
}
