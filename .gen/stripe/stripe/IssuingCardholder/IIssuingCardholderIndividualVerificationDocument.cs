using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderIndividualVerificationDocument), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividualVerificationDocument")]
    public interface IIssuingCardholderIndividualVerificationDocument
    {
        /// <summary>The back of a document returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `identity_document`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#back IssuingCardholder#back}
        /// </remarks>
        [JsiiProperty(name: "back", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Back
        {
            get
            {
                return null;
            }
        }

        /// <summary>The front of a document returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `identity_document`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#front IssuingCardholder#front}
        /// </remarks>
        [JsiiProperty(name: "front", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Front
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderIndividualVerificationDocument), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividualVerificationDocument")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderIndividualVerificationDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The back of a document returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `identity_document`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#back IssuingCardholder#back}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "back", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Back
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The front of a document returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `identity_document`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#front IssuingCardholder#front}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "front", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Front
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
