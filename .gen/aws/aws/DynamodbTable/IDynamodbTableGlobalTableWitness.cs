using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableGlobalTableWitness), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalTableWitness")]
    public interface IDynamodbTableGlobalTableWitness
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableGlobalTableWitness), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalTableWitness")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableGlobalTableWitness
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
