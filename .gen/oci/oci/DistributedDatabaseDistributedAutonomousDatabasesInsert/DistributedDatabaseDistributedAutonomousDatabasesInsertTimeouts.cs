using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsert
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabasesInsert.DistributedDatabaseDistributedAutonomousDatabasesInsertTimeouts")]
    public class DistributedDatabaseDistributedAutonomousDatabasesInsertTimeouts : oci.DistributedDatabaseDistributedAutonomousDatabasesInsert.IDistributedDatabaseDistributedAutonomousDatabasesInsertTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#create DistributedDatabaseDistributedAutonomousDatabasesInsert#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#delete DistributedDatabaseDistributedAutonomousDatabasesInsert#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#read DistributedDatabaseDistributedAutonomousDatabasesInsert#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#update DistributedDatabaseDistributedAutonomousDatabasesInsert#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
