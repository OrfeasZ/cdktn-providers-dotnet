using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsCapacityReport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilities")]
    public class BdsBdsCapacityReportShapeAvailabilities : oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_capacity_report#shape BdsBdsCapacityReport#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public string Shape
        {
            get;
            set;
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_capacity_report#shape_config BdsBdsCapacityReport#shape_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfig\"}", isOptional: true)]
        public oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig? ShapeConfig
        {
            get;
            set;
        }
    }
}
