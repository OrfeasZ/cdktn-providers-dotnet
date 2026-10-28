using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniSpace.CloudwatchomniSpaceEncryptionConfiguration")]
    public class CloudwatchomniSpaceEncryptionConfiguration : aws.CloudwatchomniSpace.ICloudwatchomniSpaceEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_space#encryption_strategy CloudwatchomniSpace#encryption_strategy}.</summary>
        [JsiiProperty(name: "encryptionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_space#kms_key_arn CloudwatchomniSpace#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }
    }
}
