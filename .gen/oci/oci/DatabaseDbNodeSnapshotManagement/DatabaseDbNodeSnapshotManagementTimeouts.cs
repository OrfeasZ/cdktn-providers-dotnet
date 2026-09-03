using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbNodeSnapshotManagement
{
    [JsiiByValue(fqn: "oci.databaseDbNodeSnapshotManagement.DatabaseDbNodeSnapshotManagementTimeouts")]
    public class DatabaseDbNodeSnapshotManagementTimeouts : oci.DatabaseDbNodeSnapshotManagement.IDatabaseDbNodeSnapshotManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_node_snapshot_management#create DatabaseDbNodeSnapshotManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_node_snapshot_management#delete DatabaseDbNodeSnapshotManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_node_snapshot_management#update DatabaseDbNodeSnapshotManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
