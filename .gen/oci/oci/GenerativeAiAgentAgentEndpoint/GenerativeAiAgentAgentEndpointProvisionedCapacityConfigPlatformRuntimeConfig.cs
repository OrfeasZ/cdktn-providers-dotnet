using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig")]
    public class GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_agent_endpoint#platform_runtime_config_type GenerativeAiAgentAgentEndpoint#platform_runtime_config_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformRuntimeConfigType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlatformRuntimeConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_agent_endpoint#version GenerativeAiAgentAgentEndpoint#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
