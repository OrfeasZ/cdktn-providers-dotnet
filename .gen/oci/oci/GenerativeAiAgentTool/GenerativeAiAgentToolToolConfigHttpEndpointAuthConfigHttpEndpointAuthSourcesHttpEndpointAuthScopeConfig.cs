using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig")]
    public class GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigHttpEndpointAuthSourcesHttpEndpointAuthScopeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_scope_config_type GenerativeAiAgentTool#http_endpoint_auth_scope_config_type}.</summary>
        [JsiiProperty(name: "httpEndpointAuthScopeConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpEndpointAuthScopeConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#client_id GenerativeAiAgentTool#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#idcs_url GenerativeAiAgentTool#idcs_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idcsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdcsUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#key_location GenerativeAiAgentTool#key_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#key_name GenerativeAiAgentTool#key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#scope_url GenerativeAiAgentTool#scope_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scopeUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScopeUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#vault_secret_id GenerativeAiAgentTool#vault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultSecretId
        {
            get;
            set;
        }
    }
}
