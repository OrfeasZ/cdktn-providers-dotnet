using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow")]
    public interface IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow
    {
        /// <summary>day_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek\"}")]
        oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek DayOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#maintenance_end_time DatabaseAutonomousDatabase#maintenance_end_time}.</summary>
        [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceEndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#maintenance_start_time DatabaseAutonomousDatabase#maintenance_start_time}.</summary>
        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>day_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
            /// </remarks>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek\"}")]
            public oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek DayOfWeek
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#maintenance_end_time DatabaseAutonomousDatabase#maintenance_end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceEndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#maintenance_start_time DatabaseAutonomousDatabase#maintenance_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
