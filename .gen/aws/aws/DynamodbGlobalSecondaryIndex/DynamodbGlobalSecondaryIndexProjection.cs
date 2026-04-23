using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjection")]
    public class DynamodbGlobalSecondaryIndexProjection : aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProjection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#projection_type DynamodbGlobalSecondaryIndex#projection_type}.</summary>
        [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#non_key_attributes DynamodbGlobalSecondaryIndex#non_key_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NonKeyAttributes
        {
            get;
            set;
        }
    }
}
