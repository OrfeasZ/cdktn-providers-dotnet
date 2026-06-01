using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketServerSideEncryptionConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public class ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault : scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        /// <summary>Server-side encryption algorithm to use. Valid values are 'AES256', 'aws:kms'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#sse_algorithm ObjectBucketServerSideEncryptionConfiguration#sse_algorithm}
        /// </remarks>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string SseAlgorithm
        {
            get;
            set;
        }

        /// <summary>Scaleway KMS master key ID used for the SSE-KMS encryption.</summary>
        /// <remarks>
        /// This can only be used when you set the value of sse_algorithm as aws:kms. Will return an error if not this element is absent while the sse_algorithm is aws:kms.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#kms_master_key_id ObjectBucketServerSideEncryptionConfiguration#kms_master_key_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsMasterKeyId
        {
            get;
            set;
        }
    }
}
