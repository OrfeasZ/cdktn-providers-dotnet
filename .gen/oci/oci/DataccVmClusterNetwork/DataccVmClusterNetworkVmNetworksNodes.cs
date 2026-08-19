using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes")]
    public class DataccVmClusterNetworkVmNetworksNodes : oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datacc_vm_cluster_network#hostname DataccVmClusterNetwork#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datacc_vm_cluster_network#ip DataccVmClusterNetwork#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datacc_vm_cluster_network#vip DataccVmClusterNetwork#vip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datacc_vm_cluster_network#vip_hostname DataccVmClusterNetwork#vip_hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VipHostname
        {
            get;
            set;
        }
    }
}
