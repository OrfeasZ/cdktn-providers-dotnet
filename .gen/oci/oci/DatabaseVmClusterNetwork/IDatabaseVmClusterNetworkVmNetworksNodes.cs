using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterNetworkVmNetworksNodes), fullyQualifiedName: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworksNodes")]
    public interface IDatabaseVmClusterNetworkVmNetworksNodes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#hostname DatabaseVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#ip DatabaseVmClusterNetwork#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        string Ip
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#db_server_id DatabaseVmClusterNetwork#db_server_id}.</summary>
        [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbServerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#state DatabaseVmClusterNetwork#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vip DatabaseVmClusterNetwork#vip}.</summary>
        [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vip_hostname DatabaseVmClusterNetwork#vip_hostname}.</summary>
        [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VipHostname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterNetworkVmNetworksNodes), fullyQualifiedName: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkVmNetworksNodes")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmClusterNetwork.IDatabaseVmClusterNetworkVmNetworksNodes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#hostname DatabaseVmClusterNetwork#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#ip DatabaseVmClusterNetwork#ip}.</summary>
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
            public string Ip
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#db_server_id DatabaseVmClusterNetwork#db_server_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbServerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#state DatabaseVmClusterNetwork#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vip DatabaseVmClusterNetwork#vip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#vip_hostname DatabaseVmClusterNetwork#vip_hostname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VipHostname
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
