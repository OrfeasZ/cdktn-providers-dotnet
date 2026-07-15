using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasePrivateEndpoint
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointTimeouts")]
    public class DistributedDatabaseDistributedDatabasePrivateEndpointTimeouts : oci.DistributedDatabaseDistributedDatabasePrivateEndpoint.IDistributedDatabaseDistributedDatabasePrivateEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database_private_endpoint#create DistributedDatabaseDistributedDatabasePrivateEndpoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database_private_endpoint#delete DistributedDatabaseDistributedDatabasePrivateEndpoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database_private_endpoint#update DistributedDatabaseDistributedDatabasePrivateEndpoint#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
