using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleDbSystemShapes
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleDbSystemShapes.DataAzurermOracleDbSystemShapesTimeouts")]
    public class DataAzurermOracleDbSystemShapesTimeouts : azurerm.DataAzurermOracleDbSystemShapes.IDataAzurermOracleDbSystemShapesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/oracle_db_system_shapes#read DataAzurermOracleDbSystemShapes#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
