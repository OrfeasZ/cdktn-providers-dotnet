using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontTrustStore
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location")]
    public class CloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location : aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_trust_store#bucket CloudfrontTrustStore#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_trust_store#key CloudfrontTrustStore#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_trust_store#region CloudfrontTrustStore#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_trust_store#version CloudfrontTrustStore#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
