using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiByValue(fqn: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkTimeouts")]
    public class DataccVmClusterNetworkTimeouts : oci.DataccVmClusterNetwork.IDataccVmClusterNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#create DataccVmClusterNetwork#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#delete DataccVmClusterNetwork#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#update DataccVmClusterNetwork#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
