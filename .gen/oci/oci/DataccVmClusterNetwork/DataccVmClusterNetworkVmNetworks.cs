using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworks")]
    public class DataccVmClusterNetworkVmNetworks : oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#domain_name DataccVmClusterNetwork#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#gateway DataccVmClusterNetwork#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public string Gateway
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#netmask DataccVmClusterNetwork#netmask}.</summary>
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public string Netmask
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#network_type DataccVmClusterNetwork#network_type}.</summary>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkType
        {
            get;
            set;
        }

        private object _nodes;

        /// <summary>nodes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#nodes DataccVmClusterNetwork#nodes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}")]
        public object Nodes
        {
            get => _nodes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nodes = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#prefix DataccVmClusterNetwork#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#vlan_id DataccVmClusterNetwork#vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VlanId
        {
            get;
            set;
        }
    }
}
