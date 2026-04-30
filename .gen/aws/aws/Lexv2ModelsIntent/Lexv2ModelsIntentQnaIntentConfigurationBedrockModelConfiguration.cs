using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration")]
    public class Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration : aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#model_arn Lexv2ModelsIntent#model_arn}.</summary>
        [JsiiProperty(name: "modelArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#custom_prompt Lexv2ModelsIntent#custom_prompt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomPrompt
        {
            get;
            set;
        }

        private object? _guardrail;

        /// <summary>guardrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#guardrail Lexv2ModelsIntent#guardrail}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardrail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Guardrail
        {
            get => _guardrail;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _guardrail = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#trace_status Lexv2ModelsIntent#trace_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "traceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TraceStatus
        {
            get;
            set;
        }
    }
}
