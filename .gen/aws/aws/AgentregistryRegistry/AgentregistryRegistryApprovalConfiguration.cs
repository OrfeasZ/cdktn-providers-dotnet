using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AgentregistryRegistry
{
    [JsiiByValue(fqn: "aws.agentregistryRegistry.AgentregistryRegistryApprovalConfiguration")]
    public class AgentregistryRegistryApprovalConfiguration : aws.AgentregistryRegistry.IAgentregistryRegistryApprovalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#auto_approval_rules AgentregistryRegistry#auto_approval_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoApprovalRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AutoApprovalRules
        {
            get;
            set;
        }
    }
}
