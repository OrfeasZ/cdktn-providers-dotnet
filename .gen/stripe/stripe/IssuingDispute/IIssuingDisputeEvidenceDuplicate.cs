using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiInterface(nativeType: typeof(IIssuingDisputeEvidenceDuplicate), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceDuplicate")]
    public interface IIssuingDisputeEvidenceDuplicate
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

        /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Copy of the card statement showing that the product had already been paid for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#card_statement IssuingDispute#card_statement}
        /// </remarks>
        [JsiiProperty(name: "cardStatement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CardStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Copy of the receipt showing that the product had been paid for in cash.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cash_receipt IssuingDispute#cash_receipt}
        /// </remarks>
        [JsiiProperty(name: "cashReceipt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CashReceipt
        {
            get
            {
                return null;
            }
        }

        /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Image of the front and back of the check that was used to pay for the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#check_image IssuingDispute#check_image}
        /// </remarks>
        [JsiiProperty(name: "checkImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CheckImage
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

        /// <summary>Transaction (e.g., ipi_...) that the disputed transaction is a duplicate of. Of the two or more transactions that are copies of each other, this is original undisputed one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#original_transaction IssuingDispute#original_transaction}
        /// </remarks>
        [JsiiProperty(name: "originalTransaction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginalTransaction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingDisputeEvidenceDuplicate), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceDuplicate")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingDispute.IIssuingDisputeEvidenceDuplicate
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

            /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Copy of the card statement showing that the product had already been paid for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#card_statement IssuingDispute#card_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cardStatement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CardStatement
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Copy of the receipt showing that the product had been paid for in cash.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#cash_receipt IssuingDispute#cash_receipt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cashReceipt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CashReceipt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(ID of a [file upload](https://stripe.com/docs/guides/file-upload)) Image of the front and back of the check that was used to pay for the product.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#check_image IssuingDispute#check_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CheckImage
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

            /// <summary>Transaction (e.g., ipi_...) that the disputed transaction is a duplicate of. Of the two or more transactions that are copies of each other, this is original undisputed one.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#original_transaction IssuingDispute#original_transaction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originalTransaction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginalTransaction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
