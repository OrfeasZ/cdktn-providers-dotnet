using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig")]
    public interface ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#trust_store_id CloudfrontDistribution#trust_store_id}.</summary>
        [JsiiProperty(name: "trustStoreId", typeJson: "{\"primitive\":\"string\"}")]
        string TrustStoreId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#advertise_trust_store_ca_names CloudfrontDistribution#advertise_trust_store_ca_names}.</summary>
        [JsiiProperty(name: "advertiseTrustStoreCaNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdvertiseTrustStoreCaNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#ignore_certificate_expiry CloudfrontDistribution#ignore_certificate_expiry}.</summary>
        [JsiiProperty(name: "ignoreCertificateExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreCertificateExpiry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#trust_store_id CloudfrontDistribution#trust_store_id}.</summary>
            [JsiiProperty(name: "trustStoreId", typeJson: "{\"primitive\":\"string\"}")]
            public string TrustStoreId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#advertise_trust_store_ca_names CloudfrontDistribution#advertise_trust_store_ca_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advertiseTrustStoreCaNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AdvertiseTrustStoreCaNames
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#ignore_certificate_expiry CloudfrontDistribution#ignore_certificate_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreCertificateExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreCertificateExpiry
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
