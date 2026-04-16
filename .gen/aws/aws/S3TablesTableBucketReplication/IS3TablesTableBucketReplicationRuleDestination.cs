using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucketReplication
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableBucketReplicationRuleDestination), fullyQualifiedName: "aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRuleDestination")]
    public interface IS3TablesTableBucketReplicationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table_bucket_replication#destination_table_bucket_arn S3TablesTableBucketReplication#destination_table_bucket_arn}.</summary>
        [JsiiProperty(name: "destinationTableBucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationTableBucketArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableBucketReplicationRuleDestination), fullyQualifiedName: "aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRuleDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableBucketReplication.IS3TablesTableBucketReplicationRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table_bucket_replication#destination_table_bucket_arn S3TablesTableBucketReplication#destination_table_bucket_arn}.</summary>
            [JsiiProperty(name: "destinationTableBucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationTableBucketArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
