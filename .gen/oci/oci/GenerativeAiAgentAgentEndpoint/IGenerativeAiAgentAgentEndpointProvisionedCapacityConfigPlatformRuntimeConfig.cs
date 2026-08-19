using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig")]
    public interface IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_agent_endpoint#platform_runtime_config_type GenerativeAiAgentAgentEndpoint#platform_runtime_config_type}.</summary>
        [JsiiProperty(name: "platformRuntimeConfigType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformRuntimeConfigType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_agent_endpoint#version GenerativeAiAgentAgentEndpoint#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_agent_endpoint#platform_runtime_config_type GenerativeAiAgentAgentEndpoint#platform_runtime_config_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platformRuntimeConfigType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformRuntimeConfigType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_agent_endpoint#version GenerativeAiAgentAgentEndpoint#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
