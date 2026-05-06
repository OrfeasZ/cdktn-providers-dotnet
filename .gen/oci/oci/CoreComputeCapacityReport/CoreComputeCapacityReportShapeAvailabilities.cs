using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilities")]
    public class CoreComputeCapacityReportShapeAvailabilities : oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#instance_shape CoreComputeCapacityReport#instance_shape}.</summary>
        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceShape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#fault_domain CoreComputeCapacityReport#fault_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FaultDomain
        {
            get;
            set;
        }

        /// <summary>instance_shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#instance_shape_config CoreComputeCapacityReport#instance_shape_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceShapeConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig\"}", isOptional: true)]
        public oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig? InstanceShapeConfig
        {
            get;
            set;
        }
    }
}
