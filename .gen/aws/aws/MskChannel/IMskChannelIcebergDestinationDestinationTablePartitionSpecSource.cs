using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelIcebergDestinationDestinationTablePartitionSpecSource), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationDestinationTablePartitionSpecSource")]
    public interface IMskChannelIcebergDestinationDestinationTablePartitionSpecSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#source_name MskChannel#source_name}.</summary>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelIcebergDestinationDestinationTablePartitionSpecSource), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationDestinationTablePartitionSpecSource")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpecSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#source_name MskChannel#source_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
