using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalSecondaryIndexProvisionedThroughput), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput")]
    public interface IDynamodbGlobalSecondaryIndexProvisionedThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#read_capacity_units DynamodbGlobalSecondaryIndex#read_capacity_units}.</summary>
        [JsiiProperty(name: "readCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadCapacityUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#write_capacity_units DynamodbGlobalSecondaryIndex#write_capacity_units}.</summary>
        [JsiiProperty(name: "writeCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteCapacityUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalSecondaryIndexProvisionedThroughput), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexProvisionedThroughput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#read_capacity_units DynamodbGlobalSecondaryIndex#read_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#write_capacity_units DynamodbGlobalSecondaryIndex#write_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "writeCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
