using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiByValue(fqn: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources")]
    public class SchServiceConnectorSourceMonitoringSources : oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>namespace_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace_details SchServiceConnector#namespace_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceDetails", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails\"}", isOptional: true)]
        public oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails? NamespaceDetails
        {
            get;
            set;
        }
    }
}
