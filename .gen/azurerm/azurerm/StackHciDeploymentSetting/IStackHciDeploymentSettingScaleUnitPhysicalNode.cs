using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiInterface(nativeType: typeof(IStackHciDeploymentSettingScaleUnitPhysicalNode), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitPhysicalNode")]
    public interface IStackHciDeploymentSettingScaleUnitPhysicalNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#ipv4_address StackHciDeploymentSetting#ipv4_address}.</summary>
        [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}")]
        string Ipv4Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#name StackHciDeploymentSetting#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciDeploymentSettingScaleUnitPhysicalNode), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitPhysicalNode")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitPhysicalNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#ipv4_address StackHciDeploymentSetting#ipv4_address}.</summary>
            [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}")]
            public string Ipv4Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/stack_hci_deployment_setting#name StackHciDeploymentSetting#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
