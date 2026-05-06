using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeHostGroup
{
    [JsiiByValue(fqn: "oci.coreComputeHostGroup.CoreComputeHostGroupConfigurations")]
    public class CoreComputeHostGroupConfigurations : oci.CoreComputeHostGroup.ICoreComputeHostGroupConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#firmware_bundle_id CoreComputeHostGroup#firmware_bundle_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firmwareBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirmwareBundleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#recycle_level CoreComputeHostGroup#recycle_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recycleLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecycleLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#target CoreComputeHostGroup#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }
    }
}
