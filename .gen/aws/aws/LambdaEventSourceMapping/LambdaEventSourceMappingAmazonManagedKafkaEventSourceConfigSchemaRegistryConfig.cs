using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig")]
    public class LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
    {
        private object? _accessConfig;

        /// <summary>access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#access_config LambdaEventSourceMapping#access_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AccessConfig
        {
            get => _accessConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdaEventSourceMapping.ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaEventSourceMapping.ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accessConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#event_record_format LambdaEventSourceMapping#event_record_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventRecordFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventRecordFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#schema_registry_uri LambdaEventSourceMapping#schema_registry_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaRegistryUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaRegistryUri
        {
            get;
            set;
        }

        private object? _schemaValidationConfig;

        /// <summary>schema_validation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#schema_validation_config LambdaEventSourceMapping#schema_validation_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaValidationConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SchemaValidationConfig
        {
            get => _schemaValidationConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdaEventSourceMapping.ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaEventSourceMapping.ILambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schemaValidationConfig = value;
            }
        }
    }
}
