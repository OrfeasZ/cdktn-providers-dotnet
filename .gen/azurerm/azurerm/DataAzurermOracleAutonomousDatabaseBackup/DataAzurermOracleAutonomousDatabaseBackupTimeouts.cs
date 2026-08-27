using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseBackup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleAutonomousDatabaseBackup.DataAzurermOracleAutonomousDatabaseBackupTimeouts")]
    public class DataAzurermOracleAutonomousDatabaseBackupTimeouts : azurerm.DataAzurermOracleAutonomousDatabaseBackup.IDataAzurermOracleAutonomousDatabaseBackupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_autonomous_database_backup#read DataAzurermOracleAutonomousDatabaseBackup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
