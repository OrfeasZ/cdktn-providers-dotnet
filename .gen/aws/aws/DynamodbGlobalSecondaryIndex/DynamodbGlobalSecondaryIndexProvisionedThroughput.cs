using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiByValue(fqn: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput")]
    public class DynamodbGlobalSecondaryIndexProvisionedThroughput : aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProvisionedThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#read_capacity_units DynamodbGlobalSecondaryIndex#read_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#write_capacity_units DynamodbGlobalSecondaryIndex#write_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteCapacityUnits
        {
            get;
            set;
        }
    }
}
