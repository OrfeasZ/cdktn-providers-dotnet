using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalSecondaryIndexKeySchema), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchema")]
    public interface IDynamodbGlobalSecondaryIndexKeySchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#attribute_name DynamodbGlobalSecondaryIndex#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#attribute_type DynamodbGlobalSecondaryIndex#attribute_type}.</summary>
        [JsiiProperty(name: "attributeType", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#key_type DynamodbGlobalSecondaryIndex#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        string KeyType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalSecondaryIndexKeySchema), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchema")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexKeySchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#attribute_name DynamodbGlobalSecondaryIndex#attribute_name}.</summary>
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#attribute_type DynamodbGlobalSecondaryIndex#attribute_type}.</summary>
            [JsiiProperty(name: "attributeType", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#key_type DynamodbGlobalSecondaryIndex#key_type}.</summary>
            [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
