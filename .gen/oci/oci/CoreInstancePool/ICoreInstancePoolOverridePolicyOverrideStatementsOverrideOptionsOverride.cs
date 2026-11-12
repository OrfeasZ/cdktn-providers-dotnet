using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride")]
    public interface ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#capacity_reservation_id CoreInstancePool#capacity_reservation_id}.</summary>
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#shape CoreInstancePool#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Shape
        {
            get
            {
                return null;
            }
        }

        /// <summary>shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#shape_config_details CoreInstancePool#shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails? ShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#capacity_reservation_id CoreInstancePool#capacity_reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#shape CoreInstancePool#shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Shape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#shape_config_details CoreInstancePool#shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails\"}", isOptional: true)]
            public oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails? ShapeConfigDetails
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails?>();
            }
        }
    }
}
