using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspaceNetworkOutboundRuleFqdn
{
    [JsiiInterface(nativeType: typeof(IMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeouts), fullyQualifiedName: "azurerm.machineLearningWorkspaceNetworkOutboundRuleFqdn.MachineLearningWorkspaceNetworkOutboundRuleFqdnTimeouts")]
    public interface IMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#create MachineLearningWorkspaceNetworkOutboundRuleFqdn#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#delete MachineLearningWorkspaceNetworkOutboundRuleFqdn#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#read MachineLearningWorkspaceNetworkOutboundRuleFqdn#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#update MachineLearningWorkspaceNetworkOutboundRuleFqdn#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeouts), fullyQualifiedName: "azurerm.machineLearningWorkspaceNetworkOutboundRuleFqdn.MachineLearningWorkspaceNetworkOutboundRuleFqdnTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.MachineLearningWorkspaceNetworkOutboundRuleFqdn.IMachineLearningWorkspaceNetworkOutboundRuleFqdnTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#create MachineLearningWorkspaceNetworkOutboundRuleFqdn#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#delete MachineLearningWorkspaceNetworkOutboundRuleFqdn#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#read MachineLearningWorkspaceNetworkOutboundRuleFqdn#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/machine_learning_workspace_network_outbound_rule_fqdn#update MachineLearningWorkspaceNetworkOutboundRuleFqdn#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
