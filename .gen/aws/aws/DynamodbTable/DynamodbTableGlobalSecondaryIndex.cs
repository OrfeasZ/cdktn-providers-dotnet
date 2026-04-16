using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndex")]
    public class DynamodbTableGlobalSecondaryIndex : aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#name DynamodbTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#projection_type DynamodbTable#projection_type}.</summary>
        [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#hash_key DynamodbTable#hash_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HashKey
        {
            get;
            set;
        }

        private object? _keySchema;

        /// <summary>key_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#key_schema DynamodbTable#key_schema}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keySchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexKeySchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeySchema
        {
            get => _keySchema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexKeySchema[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexKeySchema).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keySchema = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#non_key_attributes DynamodbTable#non_key_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NonKeyAttributes
        {
            get;
            set;
        }

        /// <summary>on_demand_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#on_demand_throughput DynamodbTable#on_demand_throughput}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexOnDemandThroughput\"}", isOptional: true)]
        public aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexOnDemandThroughput? OnDemandThroughput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#range_key DynamodbTable#range_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#read_capacity DynamodbTable#read_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadCapacity
        {
            get;
            set;
        }

        /// <summary>warm_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#warm_throughput DynamodbTable#warm_throughput}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "warmThroughput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexWarmThroughput\"}", isOptional: true)]
        public aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexWarmThroughput? WarmThroughput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dynamodb_table#write_capacity DynamodbTable#write_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteCapacity
        {
            get;
            set;
        }
    }
}
