using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleDbServers
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleDbServers.DataAzurermOracleDbServersTimeouts")]
    public class DataAzurermOracleDbServersTimeouts : azurerm.DataAzurermOracleDbServers.IDataAzurermOracleDbServersTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/oracle_db_servers#read DataAzurermOracleDbServers#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
