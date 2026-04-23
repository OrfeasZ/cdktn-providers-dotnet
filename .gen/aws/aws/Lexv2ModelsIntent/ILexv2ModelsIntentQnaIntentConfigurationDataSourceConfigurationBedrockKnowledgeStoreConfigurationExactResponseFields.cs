using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#answer_field Lexv2ModelsIntent#answer_field}.</summary>
        [JsiiProperty(name: "answerField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnswerField
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfigurationExactResponseFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#answer_field Lexv2ModelsIntent#answer_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "answerField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnswerField
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
