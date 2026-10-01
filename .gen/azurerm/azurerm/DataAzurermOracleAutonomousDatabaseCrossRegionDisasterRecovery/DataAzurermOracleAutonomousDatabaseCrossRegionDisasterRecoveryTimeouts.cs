using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts")]
    public class DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts : azurerm.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery.IDataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.8.0/docs/data-sources/oracle_autonomous_database_cross_region_disaster_recovery#read DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
