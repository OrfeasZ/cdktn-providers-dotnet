using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreClusterNetwork
{
    [JsiiInterface(nativeType: typeof(ICoreClusterNetworkClusterConfiguration), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkClusterConfiguration")]
    public interface ICoreClusterNetworkClusterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#hpc_island_id CoreClusterNetwork#hpc_island_id}.</summary>
        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        string HpcIslandId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#network_block_ids CoreClusterNetwork#network_block_ids}.</summary>
        [JsiiProperty(name: "networkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NetworkBlockIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreClusterNetworkClusterConfiguration), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkClusterConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.CoreClusterNetwork.ICoreClusterNetworkClusterConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#hpc_island_id CoreClusterNetwork#hpc_island_id}.</summary>
            [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
            public string HpcIslandId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#network_block_ids CoreClusterNetwork#network_block_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NetworkBlockIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
