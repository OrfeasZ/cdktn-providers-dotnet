using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts")]
    public interface IDataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/data-sources/oracle_autonomous_database_cross_region_disaster_recovery#read DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery.IDataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/data-sources/oracle_autonomous_database_cross_region_disaster_recovery#read DataAzurermOracleAutonomousDatabaseCrossRegionDisasterRecovery#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
