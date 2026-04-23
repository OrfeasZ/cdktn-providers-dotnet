using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfiguration")]
    public interface ILexv2ModelsIntentQnaIntentConfiguration
    {
        /// <summary>bedrock_model_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#bedrock_model_configuration Lexv2ModelsIntent#bedrock_model_configuration}
        /// </remarks>
        [JsiiProperty(name: "bedrockModelConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BedrockModelConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#data_source_configuration Lexv2ModelsIntent#data_source_configuration}
        /// </remarks>
        [JsiiProperty(name: "dataSourceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataSourceConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bedrock_model_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#bedrock_model_configuration Lexv2ModelsIntent#bedrock_model_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bedrockModelConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BedrockModelConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>data_source_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#data_source_configuration Lexv2ModelsIntent#data_source_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataSourceConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
