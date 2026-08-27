using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseBackups
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleAutonomousDatabaseBackupsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeouts")]
    public interface IDataAzurermOracleAutonomousDatabaseBackupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_autonomous_database_backups#read DataAzurermOracleAutonomousDatabaseBackups#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleAutonomousDatabaseBackupsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_autonomous_database_backups#read DataAzurermOracleAutonomousDatabaseBackups#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
