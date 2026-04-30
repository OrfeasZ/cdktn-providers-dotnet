using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfiguration")]
    public class Lexv2ModelsIntentQnaIntentConfiguration : aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfiguration
    {
        private object? _bedrockModelConfiguration;

        /// <summary>bedrock_model_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#bedrock_model_configuration Lexv2ModelsIntent#bedrock_model_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bedrockModelConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BedrockModelConfiguration
        {
            get => _bedrockModelConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bedrockModelConfiguration = value;
            }
        }

        private object? _dataSourceConfiguration;

        /// <summary>data_source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#data_source_configuration Lexv2ModelsIntent#data_source_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataSourceConfiguration
        {
            get => _dataSourceConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataSourceConfiguration = value;
            }
        }
    }
}
