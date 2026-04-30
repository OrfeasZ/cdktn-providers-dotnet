using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAbac
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketAbac.S3BucketAbacAbacStatus")]
    public class S3BucketAbacAbacStatus : aws.S3BucketAbac.IS3BucketAbacAbacStatus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3_bucket_abac#status S3BucketAbac#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
