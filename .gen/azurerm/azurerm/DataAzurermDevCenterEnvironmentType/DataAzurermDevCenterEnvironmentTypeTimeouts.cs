using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterEnvironmentType
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterEnvironmentType.DataAzurermDevCenterEnvironmentTypeTimeouts")]
    public class DataAzurermDevCenterEnvironmentTypeTimeouts : azurerm.DataAzurermDevCenterEnvironmentType.IDataAzurermDevCenterEnvironmentTypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/dev_center_environment_type#read DataAzurermDevCenterEnvironmentType#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
