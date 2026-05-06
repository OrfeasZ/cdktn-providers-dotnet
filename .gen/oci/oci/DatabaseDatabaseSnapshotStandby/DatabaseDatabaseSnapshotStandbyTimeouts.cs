using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseSnapshotStandby
{
    [JsiiByValue(fqn: "oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeouts")]
    public class DatabaseDatabaseSnapshotStandbyTimeouts : oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#create DatabaseDatabaseSnapshotStandby#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#delete DatabaseDatabaseSnapshotStandby#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#update DatabaseDatabaseSnapshotStandby#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
