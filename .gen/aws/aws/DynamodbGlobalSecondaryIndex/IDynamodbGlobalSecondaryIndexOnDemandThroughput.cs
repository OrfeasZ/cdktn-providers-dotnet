using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalSecondaryIndexOnDemandThroughput), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput")]
    public interface IDynamodbGlobalSecondaryIndexOnDemandThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#max_read_request_units DynamodbGlobalSecondaryIndex#max_read_request_units}.</summary>
        [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxReadRequestUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#max_write_request_units DynamodbGlobalSecondaryIndex#max_write_request_units}.</summary>
        [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxWriteRequestUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalSecondaryIndexOnDemandThroughput), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexOnDemandThroughput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#max_read_request_units DynamodbGlobalSecondaryIndex#max_read_request_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxReadRequestUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dynamodb_global_secondary_index#max_write_request_units DynamodbGlobalSecondaryIndex#max_write_request_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxWriteRequestUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
