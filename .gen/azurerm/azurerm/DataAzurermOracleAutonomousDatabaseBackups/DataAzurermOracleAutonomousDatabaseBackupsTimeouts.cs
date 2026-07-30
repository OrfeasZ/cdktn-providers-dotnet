using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseBackups
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeouts")]
    public class DataAzurermOracleAutonomousDatabaseBackupsTimeouts : azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_backups#read DataAzurermOracleAutonomousDatabaseBackups#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
