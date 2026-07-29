using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentProvisionedCapacity
{
    [JsiiByValue(fqn: "oci.generativeAiAgentProvisionedCapacity.GenerativeAiAgentProvisionedCapacityTimeouts")]
    public class GenerativeAiAgentProvisionedCapacityTimeouts : oci.GenerativeAiAgentProvisionedCapacity.IGenerativeAiAgentProvisionedCapacityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_agent_provisioned_capacity#create GenerativeAiAgentProvisionedCapacity#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_agent_provisioned_capacity#delete GenerativeAiAgentProvisionedCapacity#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_agent_provisioned_capacity#update GenerativeAiAgentProvisionedCapacity#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
