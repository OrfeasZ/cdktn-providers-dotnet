using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleAutonomousDatabaseCrossRegionDisasterRecovery
{
    [JsiiInterface(nativeType: typeof(IOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts), fullyQualifiedName: "azurerm.oracleAutonomousDatabaseCrossRegionDisasterRecovery.OracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts")]
    public interface IOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#create OracleAutonomousDatabaseCrossRegionDisasterRecovery#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#delete OracleAutonomousDatabaseCrossRegionDisasterRecovery#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#read OracleAutonomousDatabaseCrossRegionDisasterRecovery#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts), fullyQualifiedName: "azurerm.oracleAutonomousDatabaseCrossRegionDisasterRecovery.OracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.OracleAutonomousDatabaseCrossRegionDisasterRecovery.IOracleAutonomousDatabaseCrossRegionDisasterRecoveryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#create OracleAutonomousDatabaseCrossRegionDisasterRecovery#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#delete OracleAutonomousDatabaseCrossRegionDisasterRecovery#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.9.0/docs/resources/oracle_autonomous_database_cross_region_disaster_recovery#read OracleAutonomousDatabaseCrossRegionDisasterRecovery#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
