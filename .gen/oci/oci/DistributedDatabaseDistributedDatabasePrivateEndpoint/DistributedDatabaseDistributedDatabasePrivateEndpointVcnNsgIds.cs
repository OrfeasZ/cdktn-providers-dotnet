using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasePrivateEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasePrivateEndpoint.DistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds")]
    public class DistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds : oci.DistributedDatabaseDistributedDatabasePrivateEndpoint.IDistributedDatabaseDistributedDatabasePrivateEndpointVcnNsgIds
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#nsg_ids DistributedDatabaseDistributedDatabasePrivateEndpoint#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database_private_endpoint#vcn_id DistributedDatabaseDistributedDatabasePrivateEndpoint#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public string VcnId
        {
            get;
            set;
        }
    }
}
