using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfig")]
    public class GenerativeAiAgentAgentEndpointOutputConfig : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfig
    {
        /// <summary>output_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#output_location GenerativeAiAgentAgentEndpoint#output_location}
        /// </remarks>
        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocation\"}")]
        public oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation OutputLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#retention_period_in_minutes GenerativeAiAgentAgentEndpoint#retention_period_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriodInMinutes
        {
            get;
            set;
        }
    }
}
