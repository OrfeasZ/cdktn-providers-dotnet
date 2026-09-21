using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiByValue(fqn: "aws.mskChannel.MskChannelIcebergDestinationDestinationTablePartitionSpecSource")]
    public class MskChannelIcebergDestinationDestinationTablePartitionSpecSource : aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpecSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#source_name MskChannel#source_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceName
        {
            get;
            set;
        }
    }
}
