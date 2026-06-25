using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabasePatchOperations")]
    public class DistributedDatabaseDistributedDatabasePatchOperations : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabasePatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#operation DistributedDatabaseDistributedDatabase#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public string Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#selection DistributedDatabaseDistributedDatabase#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#value DistributedDatabaseDistributedDatabase#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
