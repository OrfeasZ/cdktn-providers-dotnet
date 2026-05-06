using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig")]
    public interface IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig
    {
        /// <summary>http_endpoint_auth_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_sources GenerativeAiAgentTool#http_endpoint_auth_sources}
        /// </remarks>
        [JsiiProperty(name: "httpEndpointAuthSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpEndpointAuthSources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>http_endpoint_auth_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_sources GenerativeAiAgentTool#http_endpoint_auth_sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpointAuthSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpEndpointAuthSources
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
