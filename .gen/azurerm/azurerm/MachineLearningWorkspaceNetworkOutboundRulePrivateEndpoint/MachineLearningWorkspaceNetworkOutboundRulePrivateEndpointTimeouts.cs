using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint
{
    [JsiiByValue(fqn: "azurerm.machineLearningWorkspaceNetworkOutboundRulePrivateEndpoint.MachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeouts")]
    public class MachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeouts : azurerm.MachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint.IMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/machine_learning_workspace_network_outbound_rule_private_endpoint#create MachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/machine_learning_workspace_network_outbound_rule_private_endpoint#delete MachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/machine_learning_workspace_network_outbound_rule_private_endpoint#read MachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
