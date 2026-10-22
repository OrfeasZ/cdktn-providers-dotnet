using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEnforcedGuardrailConfiguration
{
    [JsiiInterface(nativeType: typeof(IBedrockEnforcedGuardrailConfigurationSelectiveContentGuarding), fullyQualifiedName: "aws.bedrockEnforcedGuardrailConfiguration.BedrockEnforcedGuardrailConfigurationSelectiveContentGuarding")]
    public interface IBedrockEnforcedGuardrailConfigurationSelectiveContentGuarding
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/bedrock_enforced_guardrail_configuration#messages BedrockEnforcedGuardrailConfiguration#messages}.</summary>
        [JsiiProperty(name: "messages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Messages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/bedrock_enforced_guardrail_configuration#system BedrockEnforcedGuardrailConfiguration#system}.</summary>
        [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SystemAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEnforcedGuardrailConfigurationSelectiveContentGuarding), fullyQualifiedName: "aws.bedrockEnforcedGuardrailConfiguration.BedrockEnforcedGuardrailConfigurationSelectiveContentGuarding")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEnforcedGuardrailConfiguration.IBedrockEnforcedGuardrailConfigurationSelectiveContentGuarding
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/bedrock_enforced_guardrail_configuration#messages BedrockEnforcedGuardrailConfiguration#messages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Messages
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/bedrock_enforced_guardrail_configuration#system BedrockEnforcedGuardrailConfiguration#system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SystemAttribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
