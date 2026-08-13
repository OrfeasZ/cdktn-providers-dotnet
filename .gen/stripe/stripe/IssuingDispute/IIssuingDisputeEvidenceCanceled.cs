using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiInterface(nativeType: typeof(IIssuingDisputeEvidenceCanceled), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceCanceled")]
    public interface IIssuingDisputeEvidenceCanceled
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

        /// <summary>Whether the cardholder was provided with a cancellation policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cancellation_policy_provided IssuingDispute#cancellation_policy_provided}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "cancellationPolicyProvided", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CancellationPolicyProvided
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

        /// <summary>Date when the cardholder expected to receive the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#expected_at IssuingDispute#expected_at}
        /// </remarks>
        [JsiiProperty(name: "expectedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpectedAt
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

        [JsiiTypeProxy(nativeType: typeof(IIssuingDisputeEvidenceCanceled), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceCanceled")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingDispute.IIssuingDisputeEvidenceCanceled
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

            /// <summary>Whether the cardholder was provided with a cancellation policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cancellation_policy_provided IssuingDispute#cancellation_policy_provided}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cancellationPolicyProvided", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CancellationPolicyProvided
            {
                get => GetInstanceProperty<object?>();
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

            /// <summary>Date when the cardholder expected to receive the product.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#expected_at IssuingDispute#expected_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expectedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpectedAt
            {
                get => GetInstanceProperty<double?>();
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
