using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiInterface(nativeType: typeof(IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride")]
    public interface IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#bandwidth_percentage_smb StackHciDeploymentSetting#bandwidth_percentage_smb}.</summary>
        [JsiiProperty(name: "bandwidthPercentageSmb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BandwidthPercentageSmb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#priority_value8021_action_cluster StackHciDeploymentSetting#priority_value8021_action_cluster}.</summary>
        [JsiiProperty(name: "priorityValue8021ActionCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriorityValue8021ActionCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#priority_value8021_action_smb StackHciDeploymentSetting#priority_value8021_action_smb}.</summary>
        [JsiiProperty(name: "priorityValue8021ActionSmb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriorityValue8021ActionSmb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#bandwidth_percentage_smb StackHciDeploymentSetting#bandwidth_percentage_smb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidthPercentageSmb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BandwidthPercentageSmb
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#priority_value8021_action_cluster StackHciDeploymentSetting#priority_value8021_action_cluster}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priorityValue8021ActionCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriorityValue8021ActionCluster
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#priority_value8021_action_smb StackHciDeploymentSetting#priority_value8021_action_smb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priorityValue8021ActionSmb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriorityValue8021ActionSmb
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
