using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterNetworkDrScans), fullyQualifiedName: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkDrScans")]
    public interface IDatabaseVmClusterNetworkDrScans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#hostname DatabaseVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#ips DatabaseVmClusterNetwork#ips}.</summary>
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Ips
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#scan_listener_port_tcp DatabaseVmClusterNetwork#scan_listener_port_tcp}.</summary>
        [JsiiProperty(name: "scanListenerPortTcp", typeJson: "{\"primitive\":\"number\"}")]
        double ScanListenerPortTcp
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterNetworkDrScans), fullyQualifiedName: "oci.databaseVmClusterNetwork.DatabaseVmClusterNetworkDrScans")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmClusterNetwork.IDatabaseVmClusterNetworkDrScans
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#ips DatabaseVmClusterNetwork#ips}.</summary>
            [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Ips
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_network#scan_listener_port_tcp DatabaseVmClusterNetwork#scan_listener_port_tcp}.</summary>
            [JsiiProperty(name: "scanListenerPortTcp", typeJson: "{\"primitive\":\"number\"}")]
            public double ScanListenerPortTcp
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
