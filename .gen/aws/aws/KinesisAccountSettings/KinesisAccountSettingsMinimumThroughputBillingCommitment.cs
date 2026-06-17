using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAccountSettings
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisAccountSettings.KinesisAccountSettingsMinimumThroughputBillingCommitment")]
    public class KinesisAccountSettingsMinimumThroughputBillingCommitment : aws.KinesisAccountSettings.IKinesisAccountSettingsMinimumThroughputBillingCommitment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/kinesis_account_settings#status KinesisAccountSettings#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
