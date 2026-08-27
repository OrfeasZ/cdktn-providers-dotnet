using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride")]
    public class StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#bandwidth_percentage_smb StackHciDeploymentSetting#bandwidth_percentage_smb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidthPercentageSmb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BandwidthPercentageSmb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#priority_value8021_action_cluster StackHciDeploymentSetting#priority_value8021_action_cluster}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priorityValue8021ActionCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriorityValue8021ActionCluster
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#priority_value8021_action_smb StackHciDeploymentSetting#priority_value8021_action_smb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priorityValue8021ActionSmb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriorityValue8021ActionSmb
        {
            get;
            set;
        }
    }
}
