using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskChannel.MskChannelTopicConfigurationRecordConverter")]
    public class MskChannelTopicConfigurationRecordConverter : aws.MskChannel.IMskChannelTopicConfigurationRecordConverter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#value_converter MskChannel#value_converter}.</summary>
        [JsiiProperty(name: "valueConverter", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueConverter
        {
            get;
            set;
        }
    }
}
