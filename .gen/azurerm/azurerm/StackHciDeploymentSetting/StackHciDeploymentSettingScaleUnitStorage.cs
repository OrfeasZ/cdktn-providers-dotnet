using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitStorage")]
    public class StackHciDeploymentSettingScaleUnitStorage : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_deployment_setting#configuration_mode StackHciDeploymentSetting#configuration_mode}.</summary>
        [JsiiProperty(name: "configurationMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigurationMode
        {
            get;
            set;
        }
    }
}
