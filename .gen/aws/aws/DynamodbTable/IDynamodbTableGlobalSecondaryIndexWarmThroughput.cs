using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableGlobalSecondaryIndexWarmThroughput), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexWarmThroughput")]
    public interface IDynamodbTableGlobalSecondaryIndexWarmThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#read_units_per_second DynamodbTable#read_units_per_second}.</summary>
        [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadUnitsPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#write_units_per_second DynamodbTable#write_units_per_second}.</summary>
        [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteUnitsPerSecond
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableGlobalSecondaryIndexWarmThroughput), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexWarmThroughput")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexWarmThroughput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#read_units_per_second DynamodbTable#read_units_per_second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadUnitsPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#write_units_per_second DynamodbTable#write_units_per_second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteUnitsPerSecond
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
