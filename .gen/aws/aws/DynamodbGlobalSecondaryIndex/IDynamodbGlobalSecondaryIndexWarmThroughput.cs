using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalSecondaryIndexWarmThroughput), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput")]
    public interface IDynamodbGlobalSecondaryIndexWarmThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#read_units_per_second DynamodbGlobalSecondaryIndex#read_units_per_second}.</summary>
        [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadUnitsPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#write_units_per_second DynamodbGlobalSecondaryIndex#write_units_per_second}.</summary>
        [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteUnitsPerSecond
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalSecondaryIndexWarmThroughput), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#read_units_per_second DynamodbGlobalSecondaryIndex#read_units_per_second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadUnitsPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#write_units_per_second DynamodbGlobalSecondaryIndex#write_units_per_second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteUnitsPerSecond
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
