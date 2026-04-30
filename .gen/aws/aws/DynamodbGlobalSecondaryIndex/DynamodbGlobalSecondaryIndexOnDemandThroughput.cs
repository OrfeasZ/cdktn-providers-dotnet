using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiByValue(fqn: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput")]
    public class DynamodbGlobalSecondaryIndexOnDemandThroughput : aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexOnDemandThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#max_read_request_units DynamodbGlobalSecondaryIndex#max_read_request_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReadRequestUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#max_write_request_units DynamodbGlobalSecondaryIndex#max_write_request_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWriteRequestUnits
        {
            get;
            set;
        }
    }
}
