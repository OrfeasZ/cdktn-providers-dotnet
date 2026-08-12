using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableReplication
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableReplicationRule), fullyQualifiedName: "aws.s3TablesTableReplication.S3TablesTableReplicationRule")]
    public interface IS3TablesTableReplicationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/s3tables_table_replication#destination S3TablesTableReplication#destination}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.S3TablesTableReplication.IS3TablesTableReplicationRuleDestination" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTableReplication.S3TablesTableReplicationRuleDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Destination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableReplicationRule), fullyQualifiedName: "aws.s3TablesTableReplication.S3TablesTableReplicationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableReplication.IS3TablesTableReplicationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/s3tables_table_replication#destination S3TablesTableReplication#destination}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.S3TablesTableReplication.IS3TablesTableReplicationRuleDestination" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTableReplication.S3TablesTableReplicationRuleDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Destination
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
