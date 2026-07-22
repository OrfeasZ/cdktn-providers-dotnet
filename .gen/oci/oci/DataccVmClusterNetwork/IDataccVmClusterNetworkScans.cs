using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDataccVmClusterNetworkScans), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkScans")]
    public interface IDataccVmClusterNetworkScans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#hostname DataccVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#ips DataccVmClusterNetwork#ips}.</summary>
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Ips
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataccVmClusterNetworkScans), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkScans")]
        internal sealed class _Proxy : DeputyBase, oci.DataccVmClusterNetwork.IDataccVmClusterNetworkScans
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#hostname DataccVmClusterNetwork#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/datacc_vm_cluster_network#ips DataccVmClusterNetwork#ips}.</summary>
            [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Ips
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
