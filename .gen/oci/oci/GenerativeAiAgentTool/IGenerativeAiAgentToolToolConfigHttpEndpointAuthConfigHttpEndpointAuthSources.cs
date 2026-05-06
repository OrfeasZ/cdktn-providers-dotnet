using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources")]
    public interface IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope GenerativeAiAgentTool#http_endpoint_auth_scope}.</summary>
        [JsiiProperty(name: "httpEndpointAuthScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpEndpointAuthScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_endpoint_auth_scope_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope_config GenerativeAiAgentTool#http_endpoint_auth_scope_config}
        /// </remarks>
        [JsiiProperty(name: "httpEndpointAuthScopeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig? HttpEndpointAuthScopeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope GenerativeAiAgentTool#http_endpoint_auth_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpointAuthScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpEndpointAuthScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>http_endpoint_auth_scope_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope_config GenerativeAiAgentTool#http_endpoint_auth_scope_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpointAuthScopeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig? HttpEndpointAuthScopeConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig?>();
            }
        }
    }
}
