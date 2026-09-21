using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskChannel.MskChannelTopicConfigurationRecordSchema")]
    public class MskChannelTopicConfigurationRecordSchema : aws.MskChannel.IMskChannelTopicConfigurationRecordSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#gsr_arn MskChannel#gsr_arn}.</summary>
        [JsiiProperty(name: "gsrArn", typeJson: "{\"primitive\":\"string\"}")]
        public string GsrArn
        {
            get;
            set;
        }
    }
}
