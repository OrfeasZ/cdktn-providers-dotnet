using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterNetworkVmNetworks), fullyQualifiedName: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworks")]
    public interface IDatabaseVmClusterNetworkVmNetworks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#network_type DatabaseVmClusterNetwork#network_type}.</summary>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkType
        {
            get;
        }

        /// <summary>nodes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#nodes DatabaseVmClusterNetwork#nodes}
        /// </remarks>
        [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}")]
        object Nodes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#domain_name DatabaseVmClusterNetwork#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#gateway DatabaseVmClusterNetwork#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gateway
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#netmask DatabaseVmClusterNetwork#netmask}.</summary>
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Netmask
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vlan_id DatabaseVmClusterNetwork#vlan_id}.</summary>
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VlanId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterNetworkVmNetworks), fullyQualifiedName: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworks")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmClusterNetwork.IDatabaseVmClusterNetworkVmNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#network_type DatabaseVmClusterNetwork#network_type}.</summary>
            [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>nodes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#nodes DatabaseVmClusterNetwork#nodes}
            /// </remarks>
            [JsiiProperty(name: "nodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}")]
            public object Nodes
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#domain_name DatabaseVmClusterNetwork#domain_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#gateway DatabaseVmClusterNetwork#gateway}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gateway
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#netmask DatabaseVmClusterNetwork#netmask}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Netmask
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vlan_id DatabaseVmClusterNetwork#vlan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VlanId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
