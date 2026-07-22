using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiByValue(fqn: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails")]
    public class OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails : oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/ocvp_sddc#firewall_byol_allocation_id OcvpSddc#firewall_byol_allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirewallByolAllocationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/ocvp_sddc#vsan_byol_allocation_id OcvpSddc#vsan_byol_allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VsanByolAllocationId
        {
            get;
            set;
        }
    }
}
