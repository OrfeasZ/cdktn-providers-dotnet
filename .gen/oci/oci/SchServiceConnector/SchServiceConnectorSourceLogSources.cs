using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiByValue(fqn: "oci.schServiceConnector.SchServiceConnectorSourceLogSources")]
    public class SchServiceConnectorSourceLogSources : oci.SchServiceConnector.ISchServiceConnectorSourceLogSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_group_id SchServiceConnector#log_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_id SchServiceConnector#log_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogId
        {
            get;
            set;
        }
    }
}
