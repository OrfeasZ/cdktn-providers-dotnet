using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleAutonomousDatabaseCloneFromDatabase.DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts")]
    public class DataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts : azurerm.DataAzurermOracleAutonomousDatabaseCloneFromDatabase.IDataAzurermOracleAutonomousDatabaseCloneFromDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_autonomous_database_clone_from_database#read DataAzurermOracleAutonomousDatabaseCloneFromDatabase#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
