using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride")]
    public class StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/stack_hci_deployment_setting#enable_iov StackHciDeploymentSetting#enable_iov}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableIov", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnableIov
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/stack_hci_deployment_setting#load_balancing_algorithm StackHciDeploymentSetting#load_balancing_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancingAlgorithm
        {
            get;
            set;
        }
    }
}
