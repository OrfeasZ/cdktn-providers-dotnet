using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiByValue(fqn: "aws.mskChannel.MskChannelIcebergDestinationDestinationTable")]
    public class MskChannelIcebergDestinationDestinationTable : aws.MskChannel.IMskChannelIcebergDestinationDestinationTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#destination_database_name MskChannel#destination_database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationDatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#destination_table_name MskChannel#destination_table_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationTableName
        {
            get;
            set;
        }

        private object? _partitionSpec;

        /// <summary>partition_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#partition_spec MskChannel#partition_spec}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpec" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partitionSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelIcebergDestinationDestinationTablePartitionSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PartitionSpec
        {
            get => _partitionSpec;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpec[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelIcebergDestinationDestinationTablePartitionSpec).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _partitionSpec = value;
            }
        }
    }
}
