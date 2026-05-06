using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GloballyDistributedDatabaseShardedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabasePatchOperations")]
    public class GloballyDistributedDatabaseShardedDatabasePatchOperations : oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabasePatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#operation GloballyDistributedDatabaseShardedDatabase#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public string Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#selection GloballyDistributedDatabaseShardedDatabase#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#value GloballyDistributedDatabaseShardedDatabase#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
