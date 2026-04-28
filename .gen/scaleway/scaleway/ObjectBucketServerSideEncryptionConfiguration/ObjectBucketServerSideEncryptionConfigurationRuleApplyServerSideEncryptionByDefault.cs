using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketServerSideEncryptionConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public class ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault : scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        /// <summary>Server-side encryption algorithm to use. Valid values are AES256.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_server_side_encryption_configuration#sse_algorithm ObjectBucketServerSideEncryptionConfiguration#sse_algorithm}
        /// </remarks>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string SseAlgorithm
        {
            get;
            set;
        }
    }
}
