using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#bedrock_knowledge_base_arn Lexv2ModelsIntent#bedrock_knowledge_base_arn}.</summary>
        [JsiiProperty(name: "bedrockKnowledgeBaseArn", typeJson: "{\"primitive\":\"string\"}")]
        string BedrockKnowledgeBaseArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
        [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExactResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>exact_response_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#exact_response_fields Lexv2ModelsIntent#exact_response_fields}
        /// </remarks>
        [JsiiProperty(name: "exactResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExactResponseFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#bedrock_knowledge_base_arn Lexv2ModelsIntent#bedrock_knowledge_base_arn}.</summary>
            [JsiiProperty(name: "bedrockKnowledgeBaseArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BedrockKnowledgeBaseArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExactResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>exact_response_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#exact_response_fields Lexv2ModelsIntent#exact_response_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exactResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExactResponseFields
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
