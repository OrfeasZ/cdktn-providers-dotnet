using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseBackup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleAutonomousDatabaseBackupTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseBackup.DataAzurermOracleAutonomousDatabaseBackupTimeouts")]
    public interface IDataAzurermOracleAutonomousDatabaseBackupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_backup#read DataAzurermOracleAutonomousDatabaseBackup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleAutonomousDatabaseBackupTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseBackup.DataAzurermOracleAutonomousDatabaseBackupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleAutonomousDatabaseBackup.IDataAzurermOracleAutonomousDatabaseBackupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_backup#read DataAzurermOracleAutonomousDatabaseBackup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
