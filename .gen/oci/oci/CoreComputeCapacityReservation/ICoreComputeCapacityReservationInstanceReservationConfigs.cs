using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReservation
{
    [JsiiInterface(nativeType: typeof(ICoreComputeCapacityReservationInstanceReservationConfigs), fullyQualifiedName: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigs")]
    public interface ICoreComputeCapacityReservationInstanceReservationConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#instance_shape CoreComputeCapacityReservation#instance_shape}.</summary>
        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#reserved_count CoreComputeCapacityReservation#reserved_count}.</summary>
        [JsiiProperty(name: "reservedCount", typeJson: "{\"primitive\":\"string\"}")]
        string ReservedCount
        {
            get;
        }

        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#cluster_config CoreComputeCapacityReservation#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig? ClusterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#cluster_placement_group_id CoreComputeCapacityReservation#cluster_placement_group_id}.</summary>
        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterPlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#fault_domain CoreComputeCapacityReservation#fault_domain}.</summary>
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FaultDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#instance_shape_config CoreComputeCapacityReservation#instance_shape_config}
        /// </remarks>
        [JsiiProperty(name: "instanceShapeConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig? InstanceShapeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeCapacityReservationInstanceReservationConfigs), fullyQualifiedName: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#instance_shape CoreComputeCapacityReservation#instance_shape}.</summary>
            [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#reserved_count CoreComputeCapacityReservation#reserved_count}.</summary>
            [JsiiProperty(name: "reservedCount", typeJson: "{\"primitive\":\"string\"}")]
            public string ReservedCount
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cluster_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#cluster_config CoreComputeCapacityReservation#cluster_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfig\"}", isOptional: true)]
            public oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig? ClusterConfig
            {
                get => GetInstanceProperty<oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#cluster_placement_group_id CoreComputeCapacityReservation#cluster_placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterPlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#fault_domain CoreComputeCapacityReservation#fault_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FaultDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#instance_shape_config CoreComputeCapacityReservation#instance_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceShapeConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig\"}", isOptional: true)]
            public oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig? InstanceShapeConfig
            {
                get => GetInstanceProperty<oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig?>();
            }
        }
    }
}
