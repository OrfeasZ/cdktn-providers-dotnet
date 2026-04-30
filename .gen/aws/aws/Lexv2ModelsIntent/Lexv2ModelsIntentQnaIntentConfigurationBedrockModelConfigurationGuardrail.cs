using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail")]
    public class Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail : aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#identifier Lexv2ModelsIntent#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public string Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#version Lexv2ModelsIntent#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }
    }
}
