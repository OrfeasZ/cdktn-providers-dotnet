using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDedicatedVmHost
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetails")]
    public class CoreDedicatedVmHostPlacementConstraintDetails : oci.CoreDedicatedVmHost.ICoreDedicatedVmHostPlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#type CoreDedicatedVmHost#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#compute_bare_metal_host_id CoreDedicatedVmHost#compute_bare_metal_host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeBareMetalHostId
        {
            get;
            set;
        }
    }
}
