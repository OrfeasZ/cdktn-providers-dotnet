using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager
{
    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerTimeouts")]
    public class PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerTimeouts : azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#create PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#delete PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#read PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#update PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
