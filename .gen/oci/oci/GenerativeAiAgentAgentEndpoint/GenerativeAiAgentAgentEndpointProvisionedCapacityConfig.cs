using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfig")]
    public class GenerativeAiAgentAgentEndpointProvisionedCapacityConfig : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_agent_agent_endpoint#provisioned_capacity_id GenerativeAiAgentAgentEndpoint#provisioned_capacity_id}.</summary>
        [JsiiProperty(name: "provisionedCapacityId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProvisionedCapacityId
        {
            get;
            set;
        }

        /// <summary>platform_runtime_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_agent_agent_endpoint#platform_runtime_config GenerativeAiAgentAgentEndpoint#platform_runtime_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "platformRuntimeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig\"}", isOptional: true)]
        public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig? PlatformRuntimeConfig
        {
            get;
            set;
        }

        private object? _toolRuntimeConfigs;

        /// <summary>tool_runtime_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_agent_agent_endpoint#tool_runtime_configs GenerativeAiAgentAgentEndpoint#tool_runtime_configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "toolRuntimeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ToolRuntimeConfigs
        {
            get => _toolRuntimeConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _toolRuntimeConfigs = value;
            }
        }
    }
}
