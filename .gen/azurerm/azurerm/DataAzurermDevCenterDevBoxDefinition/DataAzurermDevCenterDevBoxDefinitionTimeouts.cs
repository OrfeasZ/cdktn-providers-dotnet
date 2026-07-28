using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterDevBoxDefinition
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterDevBoxDefinition.DataAzurermDevCenterDevBoxDefinitionTimeouts")]
    public class DataAzurermDevCenterDevBoxDefinitionTimeouts : azurerm.DataAzurermDevCenterDevBoxDefinition.IDataAzurermDevCenterDevBoxDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/dev_center_dev_box_definition#read DataAzurermDevCenterDevBoxDefinition#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
