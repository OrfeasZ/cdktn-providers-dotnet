using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpCluster
{
    [JsiiByValue(fqn: "oci.ocvpCluster.OcvpClusterClusterByolAllocationDetails")]
    public class OcvpClusterClusterByolAllocationDetails : oci.OcvpCluster.IOcvpClusterClusterByolAllocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/ocvp_cluster#firewall_byol_allocation_id OcvpCluster#firewall_byol_allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirewallByolAllocationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/ocvp_cluster#vsan_byol_allocation_id OcvpCluster#vsan_byol_allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VsanByolAllocationId
        {
            get;
            set;
        }
    }
}
