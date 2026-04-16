using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableGlobalTableWitness")]
    public class DynamodbTableGlobalTableWitness : aws.DynamodbTable.IDynamodbTableGlobalTableWitness
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionName
        {
            get;
            set;
        }
    }
}
