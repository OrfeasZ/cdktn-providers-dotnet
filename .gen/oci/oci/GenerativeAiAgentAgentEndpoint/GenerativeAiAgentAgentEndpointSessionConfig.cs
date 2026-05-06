using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointSessionConfig")]
    public class GenerativeAiAgentAgentEndpointSessionConfig : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointSessionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#idle_timeout_in_seconds GenerativeAiAgentAgentEndpoint#idle_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
