using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOracleAutonomousDatabaseLongTermBackupSchedule), fullyQualifiedName: "azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseLongTermBackupSchedule")]
    public interface IOracleAutonomousDatabaseLongTermBackupSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#enabled OracleAutonomousDatabase#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#repeat_cadence OracleAutonomousDatabase#repeat_cadence}.</summary>
        [JsiiProperty(name: "repeatCadence", typeJson: "{\"primitive\":\"string\"}")]
        string RepeatCadence
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#retention_period_in_days OracleAutonomousDatabase#retention_period_in_days}.</summary>
        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionPeriodInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#time_of_backup OracleAutonomousDatabase#time_of_backup}.</summary>
        [JsiiProperty(name: "timeOfBackup", typeJson: "{\"primitive\":\"string\"}")]
        string TimeOfBackup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOracleAutonomousDatabaseLongTermBackupSchedule), fullyQualifiedName: "azurerm.oracleAutonomousDatabase.OracleAutonomousDatabaseLongTermBackupSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.OracleAutonomousDatabase.IOracleAutonomousDatabaseLongTermBackupSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#enabled OracleAutonomousDatabase#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#repeat_cadence OracleAutonomousDatabase#repeat_cadence}.</summary>
            [JsiiProperty(name: "repeatCadence", typeJson: "{\"primitive\":\"string\"}")]
            public string RepeatCadence
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#retention_period_in_days OracleAutonomousDatabase#retention_period_in_days}.</summary>
            [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionPeriodInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/oracle_autonomous_database#time_of_backup OracleAutonomousDatabase#time_of_backup}.</summary>
            [JsiiProperty(name: "timeOfBackup", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeOfBackup
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
