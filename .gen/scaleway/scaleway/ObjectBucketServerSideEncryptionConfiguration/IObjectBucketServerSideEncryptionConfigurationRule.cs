using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketServerSideEncryptionConfiguration
{
    [JsiiInterface(nativeType: typeof(IObjectBucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRule")]
    public interface IObjectBucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#apply_server_side_encryption_by_default ObjectBucketServerSideEncryptionConfiguration#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault? ApplyServerSideEncryptionByDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not to use Scaleway Object Bucket Keys for SSE-KMS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#bucket_key_enabled ObjectBucketServerSideEncryptionConfiguration#bucket_key_enabled}
        /// </remarks>
        [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BucketKeyEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>apply_server_side_encryption_by_default block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#apply_server_side_encryption_by_default ObjectBucketServerSideEncryptionConfiguration#apply_server_side_encryption_by_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"scaleway.objectBucketServerSideEncryptionConfiguration.ObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}", isOptional: true)]
            public scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault? ApplyServerSideEncryptionByDefault
            {
                get => GetInstanceProperty<scaleway.ObjectBucketServerSideEncryptionConfiguration.IObjectBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault?>();
            }

            /// <summary>Whether or not to use Scaleway Object Bucket Keys for SSE-KMS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/object_bucket_server_side_encryption_configuration#bucket_key_enabled ObjectBucketServerSideEncryptionConfiguration#bucket_key_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BucketKeyEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
