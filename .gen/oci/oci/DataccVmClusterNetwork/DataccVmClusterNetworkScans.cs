using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkScans")]
    public class DataccVmClusterNetworkScans : oci.DataccVmClusterNetwork.IDataccVmClusterNetworkScans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datacc_vm_cluster_network#hostname DataccVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datacc_vm_cluster_network#ips DataccVmClusterNetwork#ips}.</summary>
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Ips
        {
            get;
            set;
        }
    }
}
