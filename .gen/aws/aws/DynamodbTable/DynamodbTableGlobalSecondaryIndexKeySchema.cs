using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexKeySchema")]
    public class DynamodbTableGlobalSecondaryIndexKeySchema : aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexKeySchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#attribute_name DynamodbTable#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#key_type DynamodbTable#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyType
        {
            get;
            set;
        }
    }
}
