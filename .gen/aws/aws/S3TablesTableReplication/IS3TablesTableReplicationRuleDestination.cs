using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableReplication
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableReplicationRuleDestination), fullyQualifiedName: "aws.s3TablesTableReplication.S3TablesTableReplicationRuleDestination")]
    public interface IS3TablesTableReplicationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table_replication#destination_table_bucket_arn S3TablesTableReplication#destination_table_bucket_arn}.</summary>
        [JsiiProperty(name: "destinationTableBucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationTableBucketArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableReplicationRuleDestination), fullyQualifiedName: "aws.s3TablesTableReplication.S3TablesTableReplicationRuleDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableReplication.IS3TablesTableReplicationRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table_replication#destination_table_bucket_arn S3TablesTableReplication#destination_table_bucket_arn}.</summary>
            [JsiiProperty(name: "destinationTableBucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationTableBucketArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
