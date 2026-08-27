using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterProjectEnvironmentType
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterProjectEnvironmentType.DataAzurermDevCenterProjectEnvironmentTypeTimeouts")]
    public class DataAzurermDevCenterProjectEnvironmentTypeTimeouts : azurerm.DataAzurermDevCenterProjectEnvironmentType.IDataAzurermDevCenterProjectEnvironmentTypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/dev_center_project_environment_type#read DataAzurermDevCenterProjectEnvironmentType#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
