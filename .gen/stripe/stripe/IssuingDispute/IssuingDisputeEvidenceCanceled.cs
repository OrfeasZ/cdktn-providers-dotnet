using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiByValue(fqn: "stripe.issuingDispute.IssuingDisputeEvidenceCanceled")]
    public class IssuingDisputeEvidenceCanceled : stripe.IssuingDispute.IIssuingDisputeEvidenceCanceled
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

        private object? _cancellationPolicyProvided;

        /// <summary>Whether the cardholder was provided with a cancellation policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cancellation_policy_provided IssuingDispute#cancellation_policy_provided}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cancellationPolicyProvided", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CancellationPolicyProvided
        {
            get => _cancellationPolicyProvided;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cancellationPolicyProvided = value;
            }
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

        /// <summary>Date when the cardholder expected to receive the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#expected_at IssuingDispute#expected_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expectedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpectedAt
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

        /// <summary>Description of the merchandise or service that was purchased.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#product_description IssuingDispute#product_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductDescription
        {
            get;
            set;
        }

        /// <summary>Whether the product was a merchandise or service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#product_type IssuingDispute#product_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductType
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
