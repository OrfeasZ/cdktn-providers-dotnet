using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig")]
    public interface ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
    {
        /// <summary>access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#access_config LambdaEventSourceMapping#access_config}
        /// </remarks>
        [JsiiProperty(name: "accessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#event_record_format LambdaEventSourceMapping#event_record_format}.</summary>
        [JsiiProperty(name: "eventRecordFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventRecordFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#schema_registry_uri LambdaEventSourceMapping#schema_registry_uri}.</summary>
        [JsiiProperty(name: "schemaRegistryUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaRegistryUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema_validation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#schema_validation_config LambdaEventSourceMapping#schema_validation_config}
        /// </remarks>
        [JsiiProperty(name: "schemaValidationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SchemaValidationConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaEventSourceMapping.ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#access_config LambdaEventSourceMapping#access_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AccessConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#event_record_format LambdaEventSourceMapping#event_record_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventRecordFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventRecordFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#schema_registry_uri LambdaEventSourceMapping#schema_registry_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaRegistryUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaRegistryUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schema_validation_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#schema_validation_config LambdaEventSourceMapping#schema_validation_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaValidationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SchemaValidationConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
