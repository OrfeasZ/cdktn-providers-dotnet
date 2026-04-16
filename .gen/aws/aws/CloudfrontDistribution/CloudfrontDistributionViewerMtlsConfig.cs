using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfig")]
    public class CloudfrontDistributionViewerMtlsConfig : aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution#mode CloudfrontDistribution#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>trust_store_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution#trust_store_config CloudfrontDistribution#trust_store_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustStoreConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig\"}", isOptional: true)]
        public aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig? TrustStoreConfig
        {
            get;
            set;
        }
    }
}
