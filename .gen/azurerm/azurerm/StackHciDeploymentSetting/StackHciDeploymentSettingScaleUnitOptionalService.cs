using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitOptionalService")]
    public class StackHciDeploymentSettingScaleUnitOptionalService : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitOptionalService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#custom_location StackHciDeploymentSetting#custom_location}.</summary>
        [JsiiProperty(name: "customLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomLocation
        {
            get;
            set;
        }
    }
}
