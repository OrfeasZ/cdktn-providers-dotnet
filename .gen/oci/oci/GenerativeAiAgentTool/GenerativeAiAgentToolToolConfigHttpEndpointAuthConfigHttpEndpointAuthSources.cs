using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources")]
    public class GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope GenerativeAiAgentTool#http_endpoint_auth_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointAuthScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpEndpointAuthScope
        {
            get;
            set;
        }

        /// <summary>http_endpoint_auth_scope_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope_config GenerativeAiAgentTool#http_endpoint_auth_scope_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointAuthScopeConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig? HttpEndpointAuthScopeConfig
        {
            get;
            set;
        }
    }
}
