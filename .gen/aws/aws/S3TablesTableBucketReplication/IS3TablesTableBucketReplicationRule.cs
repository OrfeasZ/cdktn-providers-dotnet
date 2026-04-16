using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucketReplication
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableBucketReplicationRule), fullyQualifiedName: "aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRule")]
    public interface IS3TablesTableBucketReplicationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table_bucket_replication#destination S3TablesTableBucketReplication#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRuleDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Destination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableBucketReplicationRule), fullyQualifiedName: "aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableBucketReplication.IS3TablesTableBucketReplicationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table_bucket_replication#destination S3TablesTableBucketReplication#destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRuleDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Destination
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
