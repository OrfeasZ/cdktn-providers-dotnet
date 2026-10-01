using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleAutonomousDatabaseCrossRegionDisasterRecovery
{
    [JsiiByValue(fqn: "azurerm.oracleAutonomousDatabaseCrossRegionDisasterRecovery.OracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts")]
    public class OracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts : azurerm.OracleAutonomousDatabaseCrossRegionDisasterRecovery.IOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.8.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#create OracleAutonomousDatabaseCrossRegionDisasterRecovery#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.8.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#delete OracleAutonomousDatabaseCrossRegionDisasterRecovery#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.8.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#read OracleAutonomousDatabaseCrossRegionDisasterRecovery#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
