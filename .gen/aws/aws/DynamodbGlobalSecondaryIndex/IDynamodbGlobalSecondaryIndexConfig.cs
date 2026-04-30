using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalSecondaryIndex
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalSecondaryIndexConfig), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexConfig")]
    public interface IDynamodbGlobalSecondaryIndexConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#index_name DynamodbGlobalSecondaryIndex#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        string IndexName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#table_name DynamodbGlobalSecondaryIndex#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        /// <summary>key_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#key_schema DynamodbGlobalSecondaryIndex#key_schema}
        /// </remarks>
        [JsiiProperty(name: "keySchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeySchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_demand_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#on_demand_throughput DynamodbGlobalSecondaryIndex#on_demand_throughput}
        /// </remarks>
        [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnDemandThroughput
        {
            get
            {
                return null;
            }
        }

        /// <summary>projection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#projection DynamodbGlobalSecondaryIndex#projection}
        /// </remarks>
        [JsiiProperty(name: "projection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Projection
        {
            get
            {
                return null;
            }
        }

        /// <summary>provisioned_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#provisioned_throughput DynamodbGlobalSecondaryIndex#provisioned_throughput}
        /// </remarks>
        [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProvisionedThroughput
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#region DynamodbGlobalSecondaryIndex#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#timeouts DynamodbGlobalSecondaryIndex#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#warm_throughput DynamodbGlobalSecondaryIndex#warm_throughput}.</summary>
        [JsiiProperty(name: "warmThroughput", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput? WarmThroughput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalSecondaryIndexConfig), fullyQualifiedName: "aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#index_name DynamodbGlobalSecondaryIndex#index_name}.</summary>
            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
            public string IndexName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#table_name DynamodbGlobalSecondaryIndex#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>key_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#key_schema DynamodbGlobalSecondaryIndex#key_schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keySchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexKeySchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KeySchema
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>on_demand_throughput block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#on_demand_throughput DynamodbGlobalSecondaryIndex#on_demand_throughput}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexOnDemandThroughput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OnDemandThroughput
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>projection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#projection DynamodbGlobalSecondaryIndex#projection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProjection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Projection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>provisioned_throughput block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#provisioned_throughput DynamodbGlobalSecondaryIndex#provisioned_throughput}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexProvisionedThroughput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProvisionedThroughput
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#region DynamodbGlobalSecondaryIndex#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#timeouts DynamodbGlobalSecondaryIndex#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexTimeouts\"}", isOptional: true)]
            public aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dynamodb_global_secondary_index#warm_throughput DynamodbGlobalSecondaryIndex#warm_throughput}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmThroughput", typeJson: "{\"fqn\":\"aws.dynamodbGlobalSecondaryIndex.DynamodbGlobalSecondaryIndexWarmThroughput\"}", isOptional: true)]
            public aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput? WarmThroughput
            {
                get => GetInstanceProperty<aws.DynamodbGlobalSecondaryIndex.IDynamodbGlobalSecondaryIndexWarmThroughput?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
