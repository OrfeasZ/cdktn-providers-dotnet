using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride")]
    public class StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_deployment_setting#jumbo_packet StackHciDeploymentSetting#jumbo_packet}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jumboPacket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JumboPacket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_deployment_setting#network_direct StackHciDeploymentSetting#network_direct}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkDirect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkDirect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_deployment_setting#network_direct_technology StackHciDeploymentSetting#network_direct_technology}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkDirectTechnology", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkDirectTechnology
        {
            get;
            set;
        }
    }
}
