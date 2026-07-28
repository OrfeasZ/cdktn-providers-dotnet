using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspaceNetworkOutboundRuleServiceTag
{
    [JsiiByValue(fqn: "azurerm.machineLearningWorkspaceNetworkOutboundRuleServiceTag.MachineLearningWorkspaceNetworkOutboundRuleServiceTagTimeouts")]
    public class MachineLearningWorkspaceNetworkOutboundRuleServiceTagTimeouts : azurerm.MachineLearningWorkspaceNetworkOutboundRuleServiceTag.IMachineLearningWorkspaceNetworkOutboundRuleServiceTagTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/machine_learning_workspace_network_outbound_rule_service_tag#create MachineLearningWorkspaceNetworkOutboundRuleServiceTag#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/machine_learning_workspace_network_outbound_rule_service_tag#delete MachineLearningWorkspaceNetworkOutboundRuleServiceTag#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/machine_learning_workspace_network_outbound_rule_service_tag#read MachineLearningWorkspaceNetworkOutboundRuleServiceTag#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/machine_learning_workspace_network_outbound_rule_service_tag#update MachineLearningWorkspaceNetworkOutboundRuleServiceTag#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
