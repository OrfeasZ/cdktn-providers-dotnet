using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReport
{
    [JsiiInterface(nativeType: typeof(ICoreComputeCapacityReportShapeAvailabilities), fullyQualifiedName: "oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilities")]
    public interface ICoreComputeCapacityReportShapeAvailabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#instance_shape CoreComputeCapacityReport#instance_shape}.</summary>
        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#fault_domain CoreComputeCapacityReport#fault_domain}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#instance_shape_config CoreComputeCapacityReport#instance_shape_config}
        /// </remarks>
        [JsiiProperty(name: "instanceShapeConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig? InstanceShapeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeCapacityReportShapeAvailabilities), fullyQualifiedName: "oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilities")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#instance_shape CoreComputeCapacityReport#instance_shape}.</summary>
            [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#fault_domain CoreComputeCapacityReport#fault_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FaultDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#instance_shape_config CoreComputeCapacityReport#instance_shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceShapeConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig\"}", isOptional: true)]
            public oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig? InstanceShapeConfig
            {
                get => GetInstanceProperty<oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig?>();
            }
        }
    }
}
