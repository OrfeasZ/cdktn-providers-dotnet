using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiInterface(nativeType: typeof(ISpacesBucketLifecycleRule), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketLifecycleRule")]
    public interface ISpacesBucketLifecycleRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#enabled SpacesBucket#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#abort_incomplete_multipart_upload_days SpacesBucket#abort_incomplete_multipart_upload_days}.</summary>
        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AbortIncompleteMultipartUploadDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#expiration SpacesBucket#expiration}
        /// </remarks>
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpiration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration? Expiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#id SpacesBucket#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>noncurrent_version_expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#noncurrent_version_expiration SpacesBucket#noncurrent_version_expiration}
        /// </remarks>
        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#prefix SpacesBucket#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpacesBucketLifecycleRule), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketLifecycleRule")]
        internal sealed class _Proxy : DeputyBase, digitalocean.SpacesBucket.ISpacesBucketLifecycleRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#enabled SpacesBucket#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#abort_incomplete_multipart_upload_days SpacesBucket#abort_incomplete_multipart_upload_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AbortIncompleteMultipartUploadDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>expiration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#expiration SpacesBucket#expiration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpiration\"}", isOptional: true)]
            public digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration? Expiration
            {
                get => GetInstanceProperty<digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>noncurrent_version_expiration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#noncurrent_version_expiration SpacesBucket#noncurrent_version_expiration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
            public digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpiration
            {
                get => GetInstanceProperty<digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#prefix SpacesBucket#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
