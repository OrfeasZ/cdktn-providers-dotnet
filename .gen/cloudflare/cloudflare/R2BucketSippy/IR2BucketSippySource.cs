using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketSippy
{
    [JsiiInterface(nativeType: typeof(IR2BucketSippySource), fullyQualifiedName: "cloudflare.r2BucketSippy.R2BucketSippySource")]
    public interface IR2BucketSippySource
    {
        /// <summary>Access Key ID of an IAM credential (ideally scoped to a single S3 bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#access_key_id R2BucketSippy#access_key_id}
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

        /// <summary>Name of the AWS S3 bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#bucket R2BucketSippy#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL to the S3-compatible API of the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#bucket_url R2BucketSippy#bucket_url}
        /// </remarks>
        [JsiiProperty(name: "bucketUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Client email of an IAM credential (ideally scoped to a single GCS bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#client_email R2BucketSippy#client_email}
        /// </remarks>
        [JsiiProperty(name: "clientEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "aws", "gcs", "s3".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#cloud_provider R2BucketSippy#cloud_provider}
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

        /// <summary>Private Key of an IAM credential (ideally scoped to a single GCS bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#private_key R2BucketSippy#private_key}
        /// </remarks>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the AWS availability zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#region R2BucketSippy#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Secret Access Key of an IAM credential (ideally scoped to a single S3 bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#secret_access_key R2BucketSippy#secret_access_key}
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

        [JsiiTypeProxy(nativeType: typeof(IR2BucketSippySource), fullyQualifiedName: "cloudflare.r2BucketSippy.R2BucketSippySource")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketSippy.IR2BucketSippySource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Access Key ID of an IAM credential (ideally scoped to a single S3 bucket).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#access_key_id R2BucketSippy#access_key_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the AWS S3 bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#bucket R2BucketSippy#bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL to the S3-compatible API of the bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#bucket_url R2BucketSippy#bucket_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Client email of an IAM credential (ideally scoped to a single GCS bucket).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#client_email R2BucketSippy#client_email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Available values: "aws", "gcs", "s3".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#cloud_provider R2BucketSippy#cloud_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Private Key of an IAM credential (ideally scoped to a single GCS bucket).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#private_key R2BucketSippy#private_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the AWS availability zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#region R2BucketSippy#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Secret Access Key of an IAM credential (ideally scoped to a single S3 bucket).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_sippy#secret_access_key R2BucketSippy#secret_access_key}
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
