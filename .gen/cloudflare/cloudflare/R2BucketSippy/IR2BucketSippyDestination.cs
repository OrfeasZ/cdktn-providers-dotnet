using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketSippy
{
    [JsiiInterface(nativeType: typeof(IR2BucketSippyDestination), fullyQualifiedName: "cloudflare.r2BucketSippy.R2BucketSippyDestination")]
    public interface IR2BucketSippyDestination
    {
        /// <summary>ID of a Cloudflare API token.</summary>
        /// <remarks>
        /// This is the value labelled "Access Key ID" when creating an API.
        /// token from the <a href="https://dash.cloudflare.com/?to=/:account/r2/api-tokens">R2 dashboard</a>.
        ///
        /// Sippy will use this token when writing objects to R2, so it is
        /// best to scope this token to the bucket you're enabling Sippy for.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#access_key_id R2BucketSippy#access_key_id}
        /// </remarks>
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "r2".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#cloud_provider R2BucketSippy#cloud_provider}
        /// </remarks>
        [JsiiProperty(name: "cloudProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Value of a Cloudflare API token.</summary>
        /// <remarks>
        /// This is the value labelled "Secret Access Key" when creating an API.
        /// token from the <a href="https://dash.cloudflare.com/?to=/:account/r2/api-tokens">R2 dashboard</a>.
        ///
        /// Sippy will use this token when writing objects to R2, so it is
        /// best to scope this token to the bucket you're enabling Sippy for.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#secret_access_key R2BucketSippy#secret_access_key}
        /// </remarks>
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretAccessKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketSippyDestination), fullyQualifiedName: "cloudflare.r2BucketSippy.R2BucketSippyDestination")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketSippy.IR2BucketSippyDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of a Cloudflare API token.</summary>
            /// <remarks>
            /// This is the value labelled "Access Key ID" when creating an API.
            /// token from the <a href="https://dash.cloudflare.com/?to=/:account/r2/api-tokens">R2 dashboard</a>.
            ///
            /// Sippy will use this token when writing objects to R2, so it is
            /// best to scope this token to the bucket you're enabling Sippy for.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#access_key_id R2BucketSippy#access_key_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Available values: "r2".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#cloud_provider R2BucketSippy#cloud_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Value of a Cloudflare API token.</summary>
            /// <remarks>
            /// This is the value labelled "Secret Access Key" when creating an API.
            /// token from the <a href="https://dash.cloudflare.com/?to=/:account/r2/api-tokens">R2 dashboard</a>.
            ///
            /// Sippy will use this token when writing objects to R2, so it is
            /// best to scope this token to the bucket you're enabling Sippy for.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_sippy#secret_access_key R2BucketSippy#secret_access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretAccessKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
