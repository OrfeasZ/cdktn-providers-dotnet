using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnection")]
    public class GenerativeAiAgentToolToolConfigDatabaseConnection : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#connection_id GenerativeAiAgentTool#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#connection_type GenerativeAiAgentTool#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionType
        {
            get;
            set;
        }
    }
}
