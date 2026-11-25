using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasePrivateEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations")]
    public class DistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations : oci.DistributedDatabaseDistributedDatabasePrivateEndpoint.IDistributedDatabaseDistributedDatabasePrivateEndpointPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#operation DistributedDatabaseDistributedDatabasePrivateEndpoint#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public string Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#selection DistributedDatabaseDistributedDatabasePrivateEndpoint#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#value DistributedDatabaseDistributedDatabasePrivateEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
