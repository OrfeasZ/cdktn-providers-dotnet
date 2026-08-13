using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiInterface(nativeType: typeof(IIssuingDisputeEvidenceOther), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceOther")]
    public interface IIssuingDisputeEvidenceOther
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

        /// <summary>Description of the merchandise or service that was purchased.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#product_description IssuingDispute#product_description}
        /// </remarks>
        [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the product was a merchandise or service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#product_type IssuingDispute#product_type}
        /// </remarks>
        [JsiiProperty(name: "productType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingDisputeEvidenceOther), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceOther")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingDispute.IIssuingDisputeEvidenceOther
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

            /// <summary>Description of the merchandise or service that was purchased.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#product_description IssuingDispute#product_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the product was a merchandise or service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#product_type IssuingDispute#product_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
