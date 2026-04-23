using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailWordPolicyConfigWordsConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig")]
    public interface IBedrockGuardrailWordPolicyConfigWordsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#text BedrockGuardrail#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        string Text
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#input_action BedrockGuardrail#input_action}.</summary>
        [JsiiProperty(name: "inputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#input_enabled BedrockGuardrail#input_enabled}.</summary>
        [JsiiProperty(name: "inputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#output_action BedrockGuardrail#output_action}.</summary>
        [JsiiProperty(name: "outputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#output_enabled BedrockGuardrail#output_enabled}.</summary>
        [JsiiProperty(name: "outputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OutputEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailWordPolicyConfigWordsConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigWordsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#text BedrockGuardrail#text}.</summary>
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
            public string Text
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#input_action BedrockGuardrail#input_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#input_enabled BedrockGuardrail#input_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InputEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#output_action BedrockGuardrail#output_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#output_enabled BedrockGuardrail#output_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OutputEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
