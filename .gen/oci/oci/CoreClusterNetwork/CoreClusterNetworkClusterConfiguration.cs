using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreClusterNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreClusterNetwork.CoreClusterNetworkClusterConfiguration")]
    public class CoreClusterNetworkClusterConfiguration : oci.CoreClusterNetwork.ICoreClusterNetworkClusterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#hpc_island_id CoreClusterNetwork#hpc_island_id}.</summary>
        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        public string HpcIslandId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#network_block_ids CoreClusterNetwork#network_block_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NetworkBlockIds
        {
            get;
            set;
        }
    }
}
