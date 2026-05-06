using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiByValue(fqn: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions")]
    public class CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions : oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions
    {
        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_port_range CoreCaptureFilter#destination_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange? DestinationPortRange
        {
            get;
            set;
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_port_range CoreCaptureFilter#source_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange? SourcePortRange
        {
            get;
            set;
        }
    }
}
