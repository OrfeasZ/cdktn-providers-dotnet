using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDataccVmClusterNetworkVmNetworksNodes), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes")]
    public interface IDataccVmClusterNetworkVmNetworksNodes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#hostname DataccVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#ip DataccVmClusterNetwork#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        string Ip
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#vip DataccVmClusterNetwork#vip}.</summary>
        [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#vip_hostname DataccVmClusterNetwork#vip_hostname}.</summary>
        [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VipHostname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataccVmClusterNetworkVmNetworksNodes), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes")]
        internal sealed class _Proxy : DeputyBase, oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#hostname DataccVmClusterNetwork#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#ip DataccVmClusterNetwork#ip}.</summary>
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
            public string Ip
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#vip DataccVmClusterNetwork#vip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_vm_cluster_network#vip_hostname DataccVmClusterNetwork#vip_hostname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VipHostname
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
