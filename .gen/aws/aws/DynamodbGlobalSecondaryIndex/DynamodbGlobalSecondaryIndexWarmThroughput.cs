using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiByValue(fqn: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput")]
    public class DynamodbGlobalSecondaryIndexWarmThroughput : aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_global_secondary_index#read_units_per_second DynamodbGlobalSecondaryIndex#read_units_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadUnitsPerSecond
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_global_secondary_index#write_units_per_second DynamodbGlobalSecondaryIndex#write_units_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteUnitsPerSecond
        {
            get;
            set;
        }
    }
}
