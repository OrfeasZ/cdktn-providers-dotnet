using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketSippy
{
    [JsiiByValue(fqn: "cloudflare.r2BucketSippy.R2BucketSippySource")]
    public class R2BucketSippySource : cloudflare.R2BucketSippy.IR2BucketSippySource
    {
        /// <summary>Access Key ID of an IAM credential (ideally scoped to a single S3 bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#access_key_id R2BucketSippy#access_key_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessKeyId
        {
            get;
            set;
        }

        /// <summary>Access key for the Azure Storage account. Mutually exclusive with sasToken.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#account_key R2BucketSippy#account_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKey
        {
            get;
            set;
        }

        /// <summary>Name of the Azure Storage account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#account_name R2BucketSippy#account_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountName
        {
            get;
            set;
        }

        /// <summary>Name of the AWS S3 bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#bucket R2BucketSippy#bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>URL to the S3-compatible API of the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#bucket_url R2BucketSippy#bucket_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketUrl
        {
            get;
            set;
        }

        /// <summary>Client email of an IAM credential (ideally scoped to a single GCS bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#client_email R2BucketSippy#client_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientEmail
        {
            get;
            set;
        }

        /// <summary>Available values: "aws", "gcs", "s3", "azure".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#cloud_provider R2BucketSippy#cloud_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudProvider
        {
            get;
            set;
        }

        /// <summary>Name of the Azure Blob Storage container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#container R2BucketSippy#container}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Container
        {
            get;
            set;
        }

        /// <summary>Private Key of an IAM credential (ideally scoped to a single GCS bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#private_key R2BucketSippy#private_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        /// <summary>Name of the AWS availability zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#region R2BucketSippy#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Shared Access Signature token for the Azure Storage account. Mutually exclusive with accountKey.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#sas_token R2BucketSippy#sas_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sasToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SasToken
        {
            get;
            set;
        }

        /// <summary>Secret Access Key of an IAM credential (ideally scoped to a single S3 bucket).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/r2_bucket_sippy#secret_access_key R2BucketSippy#secret_access_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKey
        {
            get;
            set;
        }
    }
}
