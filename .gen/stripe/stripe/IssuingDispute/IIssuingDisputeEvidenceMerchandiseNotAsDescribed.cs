using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiInterface(nativeType: typeof(IIssuingDisputeEvidenceMerchandiseNotAsDescribed), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribed")]
    public interface IIssuingDisputeEvidenceMerchandiseNotAsDescribed
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

        /// <summary>Description of the cardholder's attempt to return the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#return_description IssuingDispute#return_description}
        /// </remarks>
        [JsiiProperty(name: "returnDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReturnDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date when the product was returned or attempted to be returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#returned_at IssuingDispute#returned_at}
        /// </remarks>
        [JsiiProperty(name: "returnedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReturnedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Result of cardholder's attempt to return the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#return_status IssuingDispute#return_status}
        /// </remarks>
        [JsiiProperty(name: "returnStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReturnStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingDisputeEvidenceMerchandiseNotAsDescribed), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribed")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingDispute.IIssuingDisputeEvidenceMerchandiseNotAsDescribed
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

            /// <summary>Description of the cardholder's attempt to return the product.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#return_description IssuingDispute#return_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "returnDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReturnDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date when the product was returned or attempted to be returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#returned_at IssuingDispute#returned_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "returnedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReturnedAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Result of cardholder's attempt to return the product.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#return_status IssuingDispute#return_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "returnStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReturnStatus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
