using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailContentPolicyConfigFiltersConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig")]
    public interface IBedrockGuardrailContentPolicyConfigFiltersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_strength BedrockGuardrail#input_strength}.</summary>
        [JsiiProperty(name: "inputStrength", typeJson: "{\"primitive\":\"string\"}")]
        string InputStrength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_strength BedrockGuardrail#output_strength}.</summary>
        [JsiiProperty(name: "outputStrength", typeJson: "{\"primitive\":\"string\"}")]
        string OutputStrength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#type BedrockGuardrail#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_action BedrockGuardrail#input_action}.</summary>
        [JsiiProperty(name: "inputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_enabled BedrockGuardrail#input_enabled}.</summary>
        [JsiiProperty(name: "inputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_modalities BedrockGuardrail#input_modalities}.</summary>
        [JsiiProperty(name: "inputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InputModalities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_action BedrockGuardrail#output_action}.</summary>
        [JsiiProperty(name: "outputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_enabled BedrockGuardrail#output_enabled}.</summary>
        [JsiiProperty(name: "outputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OutputEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_modalities BedrockGuardrail#output_modalities}.</summary>
        [JsiiProperty(name: "outputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OutputModalities
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailContentPolicyConfigFiltersConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_strength BedrockGuardrail#input_strength}.</summary>
            [JsiiProperty(name: "inputStrength", typeJson: "{\"primitive\":\"string\"}")]
            public string InputStrength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_strength BedrockGuardrail#output_strength}.</summary>
            [JsiiProperty(name: "outputStrength", typeJson: "{\"primitive\":\"string\"}")]
            public string OutputStrength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#type BedrockGuardrail#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_action BedrockGuardrail#input_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_enabled BedrockGuardrail#input_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InputEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#input_modalities BedrockGuardrail#input_modalities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InputModalities
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_action BedrockGuardrail#output_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_enabled BedrockGuardrail#output_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OutputEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#output_modalities BedrockGuardrail#output_modalities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OutputModalities
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
