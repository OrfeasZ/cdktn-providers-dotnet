using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesConfigureSharding
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabasesConfigureSharding.DistributedDatabaseDistributedAutonomousDatabasesConfigureShardingTimeouts")]
    public class DistributedDatabaseDistributedAutonomousDatabasesConfigureShardingTimeouts : oci.DistributedDatabaseDistributedAutonomousDatabasesConfigureSharding.IDistributedDatabaseDistributedAutonomousDatabasesConfigureShardingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_configure_sharding#create DistributedDatabaseDistributedAutonomousDatabasesConfigureSharding#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_configure_sharding#delete DistributedDatabaseDistributedAutonomousDatabasesConfigureSharding#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_configure_sharding#read DistributedDatabaseDistributedAutonomousDatabasesConfigureSharding#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_configure_sharding#update DistributedDatabaseDistributedAutonomousDatabasesConfigureSharding#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
