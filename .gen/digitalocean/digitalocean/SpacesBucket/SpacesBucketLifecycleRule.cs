using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.spacesBucket.SpacesBucketLifecycleRule")]
    public class SpacesBucketLifecycleRule : digitalocean.SpacesBucket.ISpacesBucketLifecycleRule
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#enabled SpacesBucket#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#abort_incomplete_multipart_upload_days SpacesBucket#abort_incomplete_multipart_upload_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AbortIncompleteMultipartUploadDays
        {
            get;
            set;
        }

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#expiration SpacesBucket#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpiration\"}", isOptional: true)]
        public digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#id SpacesBucket#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>noncurrent_version_expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#noncurrent_version_expiration SpacesBucket#noncurrent_version_expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        public digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpiration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#prefix SpacesBucket#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
