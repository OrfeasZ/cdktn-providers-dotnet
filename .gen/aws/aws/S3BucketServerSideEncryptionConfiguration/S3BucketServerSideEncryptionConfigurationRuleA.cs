using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketServerSideEncryptionConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleA")]
    public class S3BucketServerSideEncryptionConfigurationRuleA : aws.S3BucketServerSideEncryptionConfiguration.IS3BucketServerSideEncryptionConfigurationRuleA
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#apply_server_side_encryption_by_default S3BucketServerSideEncryptionConfigurationA#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA\"}", isOptional: true)]
        public aws.S3BucketServerSideEncryptionConfiguration.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultA? ApplyServerSideEncryptionByDefault
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#blocked_encryption_types S3BucketServerSideEncryptionConfigurationA#blocked_encryption_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockedEncryptionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BlockedEncryptionTypes
        {
            get;
            set;
        }

        private object? _bucketKeyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_server_side_encryption_configuration#bucket_key_enabled S3BucketServerSideEncryptionConfigurationA#bucket_key_enabled}.</summary>
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
