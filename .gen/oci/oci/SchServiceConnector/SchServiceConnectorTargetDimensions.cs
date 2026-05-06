using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiByValue(fqn: "oci.schServiceConnector.SchServiceConnectorTargetDimensions")]
    public class SchServiceConnectorTargetDimensions : oci.SchServiceConnector.ISchServiceConnectorTargetDimensions
    {
        /// <summary>dimension_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#dimension_value SchServiceConnector#dimension_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensionValue", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorTargetDimensionsDimensionValue\"}", isOptional: true)]
        public oci.SchServiceConnector.ISchServiceConnectorTargetDimensionsDimensionValue? DimensionValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#name SchServiceConnector#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
