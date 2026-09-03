using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek")]
    public class DatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseScheduledMaintenanceWindowDayOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_autonomous_database#name DatabaseAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
