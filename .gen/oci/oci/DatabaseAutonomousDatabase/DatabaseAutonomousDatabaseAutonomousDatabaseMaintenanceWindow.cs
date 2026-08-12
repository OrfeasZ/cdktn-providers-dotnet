using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow")]
    public class DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow
    {
        /// <summary>day_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#day_of_week DatabaseAutonomousDatabase#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek\"}")]
        public oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#maintenance_end_time DatabaseAutonomousDatabase#maintenance_end_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceEndTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_autonomous_database#maintenance_start_time DatabaseAutonomousDatabase#maintenance_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceStartTime
        {
            get;
            set;
        }
    }
}
