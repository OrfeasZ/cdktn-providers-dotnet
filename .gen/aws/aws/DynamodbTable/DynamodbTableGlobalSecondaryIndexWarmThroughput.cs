using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexWarmThroughput")]
    public class DynamodbTableGlobalSecondaryIndexWarmThroughput : aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexWarmThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#read_units_per_second DynamodbTable#read_units_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadUnitsPerSecond
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#write_units_per_second DynamodbTable#write_units_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteUnitsPerSecond
        {
            get;
            set;
        }
    }
}
