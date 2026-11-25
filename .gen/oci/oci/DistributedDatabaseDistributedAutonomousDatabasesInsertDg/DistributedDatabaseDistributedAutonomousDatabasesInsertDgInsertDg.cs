using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg")]
    public class DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg : oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg
    {
        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#database DistributedDatabaseDistributedAutonomousDatabasesInsertDg#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase\"}")]
        public oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase Database
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#replica_name DistributedDatabaseDistributedAutonomousDatabasesInsertDg#replica_name}.</summary>
        [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
        public string ReplicaName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#selection DistributedDatabaseDistributedAutonomousDatabasesInsertDg#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }
    }
}
