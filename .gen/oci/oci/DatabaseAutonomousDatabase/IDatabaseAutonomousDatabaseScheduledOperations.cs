using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseScheduledOperations), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledOperations")]
    public interface IDatabaseAutonomousDatabaseScheduledOperations
    {
        /// <summary>day_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledOperationsDayOfWeek\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledOperationsDayOfWeek? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#scheduled_start_time DatabaseAutonomousDatabase#scheduled_start_time}.</summary>
        [JsiiProperty(name: "scheduledStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#scheduled_stop_time DatabaseAutonomousDatabase#scheduled_stop_time}.</summary>
        [JsiiProperty(name: "scheduledStopTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledStopTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseScheduledOperations), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledOperations")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>day_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledOperationsDayOfWeek\"}", isOptional: true)]
            public oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledOperationsDayOfWeek? DayOfWeek
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledOperationsDayOfWeek?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#scheduled_start_time DatabaseAutonomousDatabase#scheduled_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#scheduled_stop_time DatabaseAutonomousDatabase#scheduled_stop_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledStopTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledStopTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
