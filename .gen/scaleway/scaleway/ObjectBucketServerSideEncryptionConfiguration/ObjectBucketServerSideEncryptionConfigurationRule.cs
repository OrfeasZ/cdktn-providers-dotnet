using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketServerSideEncryptionConfiguration
{
    [JsiiByValue(fqn: "scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRule")]
    public class ObjectBucketServerSideEncryptionConfigurationRule : scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#apply_server_side_encryption_by_default ObjectBucketServerSideEncryptionConfiguration#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}", isOptional: true)]
        public scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault? ApplyServerSideEncryptionByDefault
        {
            get;
            set;
        }

        private object? _bucketKeyEnabled;

        /// <summary>Whether or not to use Scaleway Object Bucket Keys for SSE-KMS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#bucket_key_enabled ObjectBucketServerSideEncryptionConfiguration#bucket_key_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BucketKeyEnabled
        {
            get => _bucketKeyEnabled;
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
                _bucketKeyEnabled = value;
            }
        }
    }
}
