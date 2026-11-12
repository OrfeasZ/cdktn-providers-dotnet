using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride")]
    public class CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride : oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#capacity_reservation_id CoreInstancePool#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#shape CoreInstancePool#shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Shape
        {
            get;
            set;
        }

        /// <summary>shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#shape_config_details CoreInstancePool#shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails\"}", isOptional: true)]
        public oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails? ShapeConfigDetails
        {
            get;
            set;
        }
    }
}
