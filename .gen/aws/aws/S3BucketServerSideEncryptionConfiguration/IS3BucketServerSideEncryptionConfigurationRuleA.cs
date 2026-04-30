using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketServerSideEncryptionConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRuleA), fullyQualifiedName: "aws.s3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleA")]
    public interface IS3BucketServerSideEncryptionConfigurationRuleA
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#apply_server_side_encryption_by_default S3BucketServerSideEncryptionConfigurationA#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketServerSideEncryptionConfiguration.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA? ApplyServerSideEncryptionByDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#blocked_encryption_types S3BucketServerSideEncryptionConfigurationA#blocked_encryption_types}.</summary>
        [JsiiProperty(name: "blockedEncryptionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BlockedEncryptionTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#bucket_key_enabled S3BucketServerSideEncryptionConfigurationA#bucket_key_enabled}.</summary>
        [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BucketKeyEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRuleA), fullyQualifiedName: "aws.s3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleA")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketServerSideEncryptionConfiguration.IS3BucketServerSideEncryptionConfigurationRuleA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>apply_server_side_encryption_by_default block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#apply_server_side_encryption_by_default S3BucketServerSideEncryptionConfigurationA#apply_server_side_encryption_by_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA\"}", isOptional: true)]
            public aws.S3BucketServerSideEncryptionConfiguration.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA? ApplyServerSideEncryptionByDefault
            {
                get => GetInstanceProperty<aws.S3BucketServerSideEncryptionConfiguration.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#blocked_encryption_types S3BucketServerSideEncryptionConfigurationA#blocked_encryption_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockedEncryptionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BlockedEncryptionTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#bucket_key_enabled S3BucketServerSideEncryptionConfigurationA#bucket_key_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BucketKeyEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
