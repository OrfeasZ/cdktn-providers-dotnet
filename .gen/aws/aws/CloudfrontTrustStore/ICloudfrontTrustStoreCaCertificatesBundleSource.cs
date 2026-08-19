using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontTrustStore
{
    [JsiiInterface(nativeType: typeof(ICloudfrontTrustStoreCaCertificatesBundleSource), fullyQualifiedName: "aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSource")]
    public interface ICloudfrontTrustStoreCaCertificatesBundleSource
    {
        /// <summary>ca_certificates_bundle_s3_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/cloudfront_trust_store#ca_certificates_bundle_s3_location CloudfrontTrustStore#ca_certificates_bundle_s3_location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "caCertificatesBundleS3Location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaCertificatesBundleS3Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontTrustStoreCaCertificatesBundleSource), fullyQualifiedName: "aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSource")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ca_certificates_bundle_s3_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/cloudfront_trust_store#ca_certificates_bundle_s3_location CloudfrontTrustStore#ca_certificates_bundle_s3_location}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caCertificatesBundleS3Location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CaCertificatesBundleS3Location
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
