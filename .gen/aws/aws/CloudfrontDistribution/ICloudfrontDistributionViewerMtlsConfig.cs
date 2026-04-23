using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionViewerMtlsConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfig")]
    public interface ICloudfrontDistributionViewerMtlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#mode CloudfrontDistribution#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>trust_store_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#trust_store_config CloudfrontDistribution#trust_store_config}
        /// </remarks>
        [JsiiProperty(name: "trustStoreConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig? TrustStoreConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionViewerMtlsConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#mode CloudfrontDistribution#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>trust_store_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#trust_store_config CloudfrontDistribution#trust_store_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustStoreConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig\"}", isOptional: true)]
            public aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig? TrustStoreConfig
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig?>();
            }
        }
    }
}
