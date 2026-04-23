using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucketReplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3TablesTableBucketReplication.S3TablesTableBucketReplicationRuleDestination")]
    public class S3TablesTableBucketReplicationRuleDestination : aws.S3TablesTableBucketReplication.IS3TablesTableBucketReplicationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table_bucket_replication#destination_table_bucket_arn S3TablesTableBucketReplication#destination_table_bucket_arn}.</summary>
        [JsiiProperty(name: "destinationTableBucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationTableBucketArn
        {
            get;
            set;
        }
    }
}
