using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAbac
{
    [JsiiInterface(nativeType: typeof(IS3BucketAbacAbacStatus), fullyQualifiedName: "aws.s3BucketAbac.S3BucketAbacAbacStatus")]
    public interface IS3BucketAbacAbacStatus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_abac#status S3BucketAbac#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAbacAbacStatus), fullyQualifiedName: "aws.s3BucketAbac.S3BucketAbacAbacStatus")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketAbac.IS3BucketAbacAbacStatus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_abac#status S3BucketAbac#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
