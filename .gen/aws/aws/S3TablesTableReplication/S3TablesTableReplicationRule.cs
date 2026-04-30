using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableReplication
{
    [JsiiByValue(fqn: "aws.s3TablesTableReplication.S3TablesTableReplicationRule")]
    public class S3TablesTableReplicationRule : aws.S3TablesTableReplication.IS3TablesTableReplicationRule
    {
        private object? _destination;

        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3tables_table_replication#destination S3TablesTableReplication#destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTableReplication.S3TablesTableReplicationRuleDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Destination
        {
            get => _destination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3TablesTableReplication.IS3TablesTableReplicationRuleDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3TablesTableReplication.IS3TablesTableReplicationRuleDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _destination = value;
            }
        }
    }
}
