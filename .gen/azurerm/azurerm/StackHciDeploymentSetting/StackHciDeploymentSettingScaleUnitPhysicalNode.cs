using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitPhysicalNode")]
    public class StackHciDeploymentSettingScaleUnitPhysicalNode : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitPhysicalNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#ipv4_address StackHciDeploymentSetting#ipv4_address}.</summary>
        [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}")]
        public string Ipv4Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#name StackHciDeploymentSetting#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
