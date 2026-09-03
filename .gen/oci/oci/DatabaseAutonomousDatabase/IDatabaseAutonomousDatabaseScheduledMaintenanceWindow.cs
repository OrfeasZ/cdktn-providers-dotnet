using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseScheduledMaintenanceWindow), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledMaintenanceWindow")]
    public interface IDatabaseAutonomousDatabaseScheduledMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#availability_domain DatabaseAutonomousDatabase#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>day_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#is_maintenance_window_change_scheduled DatabaseAutonomousDatabase#is_maintenance_window_change_scheduled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMaintenanceWindowChangeScheduled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMaintenanceWindowChangeScheduled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#maintenance_end_time DatabaseAutonomousDatabase#maintenance_end_time}.</summary>
        [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceEndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#maintenance_start_time DatabaseAutonomousDatabase#maintenance_start_time}.</summary>
        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseScheduledMaintenanceWindow), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#availability_domain DatabaseAutonomousDatabase#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>day_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DayOfWeek
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#is_maintenance_window_change_scheduled DatabaseAutonomousDatabase#is_maintenance_window_change_scheduled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isMaintenanceWindowChangeScheduled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMaintenanceWindowChangeScheduled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#maintenance_end_time DatabaseAutonomousDatabase#maintenance_end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceEndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#maintenance_start_time DatabaseAutonomousDatabase#maintenance_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
