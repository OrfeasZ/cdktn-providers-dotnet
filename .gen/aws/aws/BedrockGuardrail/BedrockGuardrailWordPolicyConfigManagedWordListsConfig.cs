using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigManagedWordListsConfig")]
    public class BedrockGuardrailWordPolicyConfigManagedWordListsConfig : aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigManagedWordListsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#type BedrockGuardrail#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#input_action BedrockGuardrail#input_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputAction
        {
            get;
            set;
        }

        private object? _inputEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#input_enabled BedrockGuardrail#input_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InputEnabled
        {
            get => _inputEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#output_action BedrockGuardrail#output_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputAction
        {
            get;
            set;
        }

        private object? _outputEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#output_enabled BedrockGuardrail#output_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OutputEnabled
        {
            get => _outputEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outputEnabled = value;
            }
        }
    }
}
