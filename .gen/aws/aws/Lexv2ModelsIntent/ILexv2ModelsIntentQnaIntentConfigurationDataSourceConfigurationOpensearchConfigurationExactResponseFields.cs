using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#answer_field Lexv2ModelsIntent#answer_field}.</summary>
        [JsiiProperty(name: "answerField", typeJson: "{\"primitive\":\"string\"}")]
        string AnswerField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#question_field Lexv2ModelsIntent#question_field}.</summary>
        [JsiiProperty(name: "questionField", typeJson: "{\"primitive\":\"string\"}")]
        string QuestionField
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#answer_field Lexv2ModelsIntent#answer_field}.</summary>
            [JsiiProperty(name: "answerField", typeJson: "{\"primitive\":\"string\"}")]
            public string AnswerField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#question_field Lexv2ModelsIntent#question_field}.</summary>
            [JsiiProperty(name: "questionField", typeJson: "{\"primitive\":\"string\"}")]
            public string QuestionField
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
