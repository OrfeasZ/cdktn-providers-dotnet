using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskChannel.MskChannelS3DestinationDeadLetterQueueS3")]
    public class MskChannelS3DestinationDeadLetterQueueS3 : aws.MskChannel.IMskChannelS3DestinationDeadLetterQueueS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#bucket_arn MskChannel#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#error_output_prefix MskChannel#error_output_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorOutputPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#expected_bucket_owner MskChannel#expected_bucket_owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expectedBucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpectedBucketOwner
        {
            get;
            set;
        }
    }
}
