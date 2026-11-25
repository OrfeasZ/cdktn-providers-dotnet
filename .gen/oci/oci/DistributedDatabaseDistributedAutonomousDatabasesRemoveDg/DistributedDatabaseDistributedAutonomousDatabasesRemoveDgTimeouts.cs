using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts")]
    public class DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts : oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#create DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#delete DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#read DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#update DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
