using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiInterface(nativeType: typeof(IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails")]
    public interface IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ocvp_sddc#firewall_byol_allocation_id OcvpSddc#firewall_byol_allocation_id}.</summary>
        [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirewallByolAllocationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ocvp_sddc#vsan_byol_allocation_id OcvpSddc#vsan_byol_allocation_id}.</summary>
        [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VsanByolAllocationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsClusterByolAllocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ocvp_sddc#firewall_byol_allocation_id OcvpSddc#firewall_byol_allocation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirewallByolAllocationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ocvp_sddc#vsan_byol_allocation_id OcvpSddc#vsan_byol_allocation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VsanByolAllocationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
