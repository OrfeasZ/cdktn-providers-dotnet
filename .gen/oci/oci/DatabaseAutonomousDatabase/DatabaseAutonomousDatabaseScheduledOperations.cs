using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledOperations")]
    public class DatabaseAutonomousDatabaseScheduledOperations : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledOperations
    {
        /// <summary>day_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledOperationsDayOfWeek\"}", isOptional: true)]
        public oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledOperationsDayOfWeek? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#scheduled_start_time DatabaseAutonomousDatabase#scheduled_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduledStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#scheduled_stop_time DatabaseAutonomousDatabase#scheduled_stop_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledStopTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduledStopTime
        {
            get;
            set;
        }
    }
}
