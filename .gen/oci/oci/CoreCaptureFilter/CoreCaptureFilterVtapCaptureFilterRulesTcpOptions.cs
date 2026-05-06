using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiByValue(fqn: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions")]
    public class CoreCaptureFilterVtapCaptureFilterRulesTcpOptions : oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions
    {
        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_port_range CoreCaptureFilter#destination_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange? DestinationPortRange
        {
            get;
            set;
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_port_range CoreCaptureFilter#source_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange? SourcePortRange
        {
            get;
            set;
        }
    }
}
