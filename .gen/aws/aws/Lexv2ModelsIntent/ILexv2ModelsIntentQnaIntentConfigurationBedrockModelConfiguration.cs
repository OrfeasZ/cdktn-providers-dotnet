using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#model_arn Lexv2ModelsIntent#model_arn}.</summary>
        [JsiiProperty(name: "modelArn", typeJson: "{\"primitive\":\"string\"}")]
        string ModelArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#custom_prompt Lexv2ModelsIntent#custom_prompt}.</summary>
        [JsiiProperty(name: "customPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>guardrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#guardrail Lexv2ModelsIntent#guardrail}
        /// </remarks>
        [JsiiProperty(name: "guardrail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Guardrail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#trace_status Lexv2ModelsIntent#trace_status}.</summary>
        [JsiiProperty(name: "traceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TraceStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationBedrockModelConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#model_arn Lexv2ModelsIntent#model_arn}.</summary>
            [JsiiProperty(name: "modelArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#custom_prompt Lexv2ModelsIntent#custom_prompt}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomPrompt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>guardrail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#guardrail Lexv2ModelsIntent#guardrail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardrail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationBedrockModelConfigurationGuardrail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Guardrail
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#trace_status Lexv2ModelsIntent#trace_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "traceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TraceStatus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
