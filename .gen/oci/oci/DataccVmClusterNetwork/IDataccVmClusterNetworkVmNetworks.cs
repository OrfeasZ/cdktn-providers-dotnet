using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDataccVmClusterNetworkVmNetworks), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworks")]
    public interface IDataccVmClusterNetworkVmNetworks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#domain_name DataccVmClusterNetwork#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#gateway DataccVmClusterNetwork#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        string Gateway
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#netmask DataccVmClusterNetwork#netmask}.</summary>
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        string Netmask
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#network_type DataccVmClusterNetwork#network_type}.</summary>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkType
        {
            get;
        }

        /// <summary>nodes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#nodes DataccVmClusterNetwork#nodes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}")]
        object Nodes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#prefix DataccVmClusterNetwork#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#vlan_id DataccVmClusterNetwork#vlan_id}.</summary>
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VlanId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataccVmClusterNetworkVmNetworks), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworks")]
        internal sealed class _Proxy : DeputyBase, oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#domain_name DataccVmClusterNetwork#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#gateway DataccVmClusterNetwork#gateway}.</summary>
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
            public string Gateway
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#netmask DataccVmClusterNetwork#netmask}.</summary>
            [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
            public string Netmask
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#network_type DataccVmClusterNetwork#network_type}.</summary>
            [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>nodes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#nodes DataccVmClusterNetwork#nodes}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}")]
            public object Nodes
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#prefix DataccVmClusterNetwork#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datacc_vm_cluster_network#vlan_id DataccVmClusterNetwork#vlan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VlanId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
