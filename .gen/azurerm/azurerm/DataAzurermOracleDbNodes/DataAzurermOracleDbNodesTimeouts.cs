using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleDbNodes
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleDbNodes.DataAzurermOracleDbNodesTimeouts")]
    public class DataAzurermOracleDbNodesTimeouts : azurerm.DataAzurermOracleDbNodes.IDataAzurermOracleDbNodesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/oracle_db_nodes#read DataAzurermOracleDbNodes#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
