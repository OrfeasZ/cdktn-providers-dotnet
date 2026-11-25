using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesRemoveDg
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesRemoveDg.DistributedDatabaseDistributedDatabasesRemoveDgRemoveDg")]
    public class DistributedDatabaseDistributedDatabasesRemoveDgRemoveDg : oci.DistributedDatabaseDistributedDatabasesRemoveDg.IDistributedDatabaseDistributedDatabasesRemoveDgRemoveDg
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove_dg#replica_name DistributedDatabaseDistributedDatabasesRemoveDg#replica_name}.</summary>
        [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
        public string ReplicaName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove_dg#selection DistributedDatabaseDistributedDatabasesRemoveDg#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }
    }
}
