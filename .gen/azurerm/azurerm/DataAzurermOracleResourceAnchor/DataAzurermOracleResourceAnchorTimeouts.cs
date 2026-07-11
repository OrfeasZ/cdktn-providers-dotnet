using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleResourceAnchor
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleResourceAnchor.DataAzurermOracleResourceAnchorTimeouts")]
    public class DataAzurermOracleResourceAnchorTimeouts : azurerm.DataAzurermOracleResourceAnchor.IDataAzurermOracleResourceAnchorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_resource_anchor#read DataAzurermOracleResourceAnchor#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
