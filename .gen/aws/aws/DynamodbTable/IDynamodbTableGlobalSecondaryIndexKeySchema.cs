using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableGlobalSecondaryIndexKeySchema), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexKeySchema")]
    public interface IDynamodbTableGlobalSecondaryIndexKeySchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#attribute_name DynamodbTable#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#key_type DynamodbTable#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        string KeyType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableGlobalSecondaryIndexKeySchema), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexKeySchema")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexKeySchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#attribute_name DynamodbTable#attribute_name}.</summary>
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#key_type DynamodbTable#key_type}.</summary>
            [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
