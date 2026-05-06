using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReport
{
    [JsiiByValue(fqn: "oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig")]
    public class CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig : oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#memory_in_gbs CoreComputeCapacityReport#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#nvmes CoreComputeCapacityReport#nvmes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Nvmes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_report#ocpus CoreComputeCapacityReport#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
