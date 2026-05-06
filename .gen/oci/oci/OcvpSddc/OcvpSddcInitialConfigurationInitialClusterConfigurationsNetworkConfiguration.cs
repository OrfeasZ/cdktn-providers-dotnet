using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration")]
    public class OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration : oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#nsx_edge_vtep_vlan_id OcvpSddc#nsx_edge_vtep_vlan_id}.</summary>
        [JsiiProperty(name: "nsxEdgeVtepVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public string NsxEdgeVtepVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#nsx_vtep_vlan_id OcvpSddc#nsx_vtep_vlan_id}.</summary>
        [JsiiProperty(name: "nsxVtepVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public string NsxVtepVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#provisioning_subnet_id OcvpSddc#provisioning_subnet_id}.</summary>
        [JsiiProperty(name: "provisioningSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProvisioningSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#vmotion_vlan_id OcvpSddc#vmotion_vlan_id}.</summary>
        [JsiiProperty(name: "vmotionVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public string VmotionVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#vsan_vlan_id OcvpSddc#vsan_vlan_id}.</summary>
        [JsiiProperty(name: "vsanVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public string VsanVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#hcx_vlan_id OcvpSddc#hcx_vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hcxVlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HcxVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#nsx_edge_uplink1vlan_id OcvpSddc#nsx_edge_uplink1vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsxEdgeUplink1VlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NsxEdgeUplink1VlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#nsx_edge_uplink2vlan_id OcvpSddc#nsx_edge_uplink2vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsxEdgeUplink2VlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NsxEdgeUplink2VlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#provisioning_vlan_id OcvpSddc#provisioning_vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisioningVlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProvisioningVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#replication_vlan_id OcvpSddc#replication_vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationVlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationVlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#vsphere_vlan_id OcvpSddc#vsphere_vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vsphereVlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VsphereVlanId
        {
            get;
            set;
        }
    }
}
