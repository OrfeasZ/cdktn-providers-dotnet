using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstance.CoreInstancePlacementConstraintDetails")]
    public class CoreInstancePlacementConstraintDetails : oci.CoreInstance.ICoreInstancePlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#type CoreInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compute_bare_metal_host_id CoreInstance#compute_bare_metal_host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeBareMetalHostId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compute_host_group_id CoreInstance#compute_host_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeHostGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeHostGroupId
        {
            get;
            set;
        }
    }
}
