using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentEndpointGuardrailConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfig")]
    public interface IGenerativeAiAgentAgentEndpointGuardrailConfig
    {
        /// <summary>content_moderation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#content_moderation_config GenerativeAiAgentAgentEndpoint#content_moderation_config}
        /// </remarks>
        [JsiiProperty(name: "contentModerationConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig? ContentModerationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>personally_identifiable_information_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#personally_identifiable_information_config GenerativeAiAgentAgentEndpoint#personally_identifiable_information_config}
        /// </remarks>
        [JsiiProperty(name: "personallyIdentifiableInformationConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig? PersonallyIdentifiableInformationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>prompt_injection_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#prompt_injection_config GenerativeAiAgentAgentEndpoint#prompt_injection_config}
        /// </remarks>
        [JsiiProperty(name: "promptInjectionConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig? PromptInjectionConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentEndpointGuardrailConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content_moderation_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#content_moderation_config GenerativeAiAgentAgentEndpoint#content_moderation_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentModerationConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig\"}", isOptional: true)]
            public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig? ContentModerationConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig?>();
            }

            /// <summary>personally_identifiable_information_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#personally_identifiable_information_config GenerativeAiAgentAgentEndpoint#personally_identifiable_information_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "personallyIdentifiableInformationConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig\"}", isOptional: true)]
            public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig? PersonallyIdentifiableInformationConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig?>();
            }

            /// <summary>prompt_injection_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#prompt_injection_config GenerativeAiAgentAgentEndpoint#prompt_injection_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "promptInjectionConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig\"}", isOptional: true)]
            public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig? PromptInjectionConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig?>();
            }
        }
    }
}
