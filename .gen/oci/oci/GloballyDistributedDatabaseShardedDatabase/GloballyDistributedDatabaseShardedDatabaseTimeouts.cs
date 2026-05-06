using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GloballyDistributedDatabaseShardedDatabase
{
    [JsiiByValue(fqn: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseTimeouts")]
    public class GloballyDistributedDatabaseShardedDatabaseTimeouts : oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#create GloballyDistributedDatabaseShardedDatabase#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#delete GloballyDistributedDatabaseShardedDatabase#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#update GloballyDistributedDatabaseShardedDatabase#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
