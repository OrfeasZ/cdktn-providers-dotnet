using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfig")]
    public interface IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_agent_agent_endpoint#provisioned_capacity_id GenerativeAiAgentAgentEndpoint#provisioned_capacity_id}.</summary>
        [JsiiProperty(name: "provisionedCapacityId", typeJson: "{\"primitive\":\"string\"}")]
        string ProvisionedCapacityId
        {
            get;
        }

        /// <summary>platform_runtime_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_agent_agent_endpoint#platform_runtime_config GenerativeAiAgentAgentEndpoint#platform_runtime_config}
        /// </remarks>
        [JsiiProperty(name: "platformRuntimeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig? PlatformRuntimeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>tool_runtime_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_agent_agent_endpoint#tool_runtime_configs GenerativeAiAgentAgentEndpoint#tool_runtime_configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "toolRuntimeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ToolRuntimeConfigs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_agent_agent_endpoint#provisioned_capacity_id GenerativeAiAgentAgentEndpoint#provisioned_capacity_id}.</summary>
            [JsiiProperty(name: "provisionedCapacityId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProvisionedCapacityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>platform_runtime_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_agent_agent_endpoint#platform_runtime_config GenerativeAiAgentAgentEndpoint#platform_runtime_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "platformRuntimeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig\"}", isOptional: true)]
            public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig? PlatformRuntimeConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigPlatformRuntimeConfig?>();
            }

            /// <summary>tool_runtime_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_agent_agent_endpoint#tool_runtime_configs GenerativeAiAgentAgentEndpoint#tool_runtime_configs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "toolRuntimeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ToolRuntimeConfigs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
