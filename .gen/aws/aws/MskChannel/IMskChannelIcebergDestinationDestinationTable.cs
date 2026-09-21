using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelIcebergDestinationDestinationTable), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationDestinationTable")]
    public interface IMskChannelIcebergDestinationDestinationTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#destination_database_name MskChannel#destination_database_name}.</summary>
        [JsiiProperty(name: "destinationDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationDatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#destination_table_name MskChannel#destination_table_name}.</summary>
        [JsiiProperty(name: "destinationTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationTableName
        {
            get
            {
                return null;
            }
        }

        /// <summary>partition_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#partition_spec MskChannel#partition_spec}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpec" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "partitionSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDestinationTablePartitionSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PartitionSpec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelIcebergDestinationDestinationTable), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationDestinationTable")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelIcebergDestinationDestinationTable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#destination_database_name MskChannel#destination_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#destination_table_name MskChannel#destination_table_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationTableName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>partition_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#partition_spec MskChannel#partition_spec}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpec" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partitionSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDestinationTablePartitionSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PartitionSpec
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
