using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpCluster
{
    [JsiiInterface(nativeType: typeof(IOcvpClusterClusterByolAllocationDetails), fullyQualifiedName: "oci.ocvpCluster.OcvpClusterClusterByolAllocationDetails")]
    public interface IOcvpClusterClusterByolAllocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ocvp_cluster#firewall_byol_allocation_id OcvpCluster#firewall_byol_allocation_id}.</summary>
        [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirewallByolAllocationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ocvp_cluster#vsan_byol_allocation_id OcvpCluster#vsan_byol_allocation_id}.</summary>
        [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VsanByolAllocationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpClusterClusterByolAllocationDetails), fullyQualifiedName: "oci.ocvpCluster.OcvpClusterClusterByolAllocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpCluster.IOcvpClusterClusterByolAllocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ocvp_cluster#firewall_byol_allocation_id OcvpCluster#firewall_byol_allocation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firewallByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirewallByolAllocationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ocvp_cluster#vsan_byol_allocation_id OcvpCluster#vsan_byol_allocation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vsanByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VsanByolAllocationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
