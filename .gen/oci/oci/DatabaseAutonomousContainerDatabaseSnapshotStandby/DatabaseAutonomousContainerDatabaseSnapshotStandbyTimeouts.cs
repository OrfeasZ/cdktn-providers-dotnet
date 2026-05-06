using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseSnapshotStandby
{
    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabaseSnapshotStandby.DatabaseAutonomousContainerDatabaseSnapshotStandbyTimeouts")]
    public class DatabaseAutonomousContainerDatabaseSnapshotStandbyTimeouts : oci.DatabaseAutonomousContainerDatabaseSnapshotStandby.IDatabaseAutonomousContainerDatabaseSnapshotStandbyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_snapshot_standby#create DatabaseAutonomousContainerDatabaseSnapshotStandby#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_snapshot_standby#delete DatabaseAutonomousContainerDatabaseSnapshotStandby#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_snapshot_standby#update DatabaseAutonomousContainerDatabaseSnapshotStandby#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
